using UnityEngine;

/// <summary>
/// Receive the input from the controller and applies the actions to the character
/// </summary>
[RequireComponent(typeof(CharacterController), typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
	[Header("Configuration")]
	[SerializeField] private InputReader inputReader = default;
	[SerializeField] private CharacterMovementSO moveSO = default;
	[SerializeField] private CameraConfigSO cameraConfigSO = default;

	[Tooltip("Camera target in the character.")]
	[SerializeField] private GameObject cinemachineCameraTarget;

	// Player references
	float targetRotation = 0.0f;
	float targetSpeed = 0.0f;

	public Vector3 MoveDirection { get; private set; }
	public bool IsRunning { get; private set; }

	// Camera references
	float cinemachineTargetYaw;
	float cinemachineTargetPitch;

	// Dependencies
	Camera mainCamera;
	CharacterController controller;

	#region Subscriptions events
	private void OnEnable()
	{
		inputReader.MoveEvent += OnMove;
		inputReader.LookEvent += OnLook;
		inputReader.StartRunningEvent += OnStartRun;
		inputReader.StopRunningEvent += OnStopRun;
	}

	private void OnDisable()
	{
		inputReader.MoveEvent -= OnMove;
		inputReader.LookEvent -= OnLook;
		inputReader.StartRunningEvent -= OnStartRun;
		inputReader.StopRunningEvent -= OnStopRun;
	}
    #endregion

    private void Awake()
    {
		// Get a reference to the main camera
		if (mainCamera == null)
		{
			mainCamera = Camera.main;
		}

		controller = GetComponent<CharacterController>();
	}

   	private void Update()
    {
        UpdateMovement();
		UpdateCameraRotation();
	}

    private void UpdateMovement()
    {
        // Set Speed
        targetSpeed = IsRunning ? moveSO.RunSpeed : moveSO.WalkSpeed;

        if (MoveDirection == Vector3.zero) targetSpeed = 0.0f;
        else
        {
			/////////// ROTATION ///////////
			float rotationSpeed = moveSO.RotationSpeed;

            targetRotation = 
				Mathf.Atan2(MoveDirection.x, MoveDirection.z) * Mathf.Rad2Deg + mainCamera.transform.eulerAngles.y;

			float rotation = 
				Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref rotationSpeed, moveSO.RotationSmoothTime);

            transform.rotation = Quaternion.Euler(0.0f, rotation, 0.0f);
        }

		Vector3 targetDirection = Quaternion.Euler(0.0f, targetRotation, 0.0f) * Vector3.forward;

		/////////// MOVE ///////////
		controller.Move(targetSpeed * Time.deltaTime * targetDirection + new Vector3(0, moveSO.Gravity, 0) * Time.deltaTime);

    }

	

	private void UpdateCameraRotation()
	{
		cinemachineCameraTarget.transform.rotation = Quaternion.Euler(cinemachineTargetPitch,
			cinemachineTargetYaw + cameraConfigSO.CameraAngleOverride, 0.0f);
	}
	

	#region Event Listeners
	private void OnMove(Vector2 input)
    {
		// move direction represents the direction of the character
		MoveDirection = new(input.x, 0, input.y);
    }

	private void OnLook(Vector2 input)
    {
		if (!cameraConfigSO.LockCameraPosition)
		{
			cinemachineTargetYaw += input.x * cameraConfigSO.Sensitivity;
			cinemachineTargetPitch -= input.y * cameraConfigSO.Sensitivity;
		}

		// Rotation target angles
		cinemachineTargetYaw = cameraConfigSO.ClampAngle(cinemachineTargetYaw, float.MinValue, float.MaxValue);
		cinemachineTargetPitch = cameraConfigSO.ClampAngle(cinemachineTargetPitch, cameraConfigSO.BottomClamp, cameraConfigSO.TopClamp);
	}

	private void OnStartRun()
    {
		IsRunning = true;
	}

	private void OnStopRun()
	{
		IsRunning = false;
	}
    #endregion
}
