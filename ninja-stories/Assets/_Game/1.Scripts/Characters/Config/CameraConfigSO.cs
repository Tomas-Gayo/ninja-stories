using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NewCameraConfig", menuName = "Scriptable Objects/Config/Camera Config")]
public class CameraConfigSO : ScriptableObject
{
    [SerializeField, Tooltip("How sensitive the camera movement is.")]
    private float sensitivity;

    [SerializeField, Tooltip("Check this to block the rotation of the camera.")]
    private bool lockCameraPosition = false;
    [SerializeField, Tooltip("Additional degress to override the camera. Use it only when camera is locked.")]
    private float cameraAngleOverride = 0.0f;
    
    [SerializeField, Tooltip("How far in degrees you can move the camera up")]
    private float topClamp = 70.0f;
    [SerializeField,Tooltip("How far in degrees can you move the camera down")]
    private float bottomClamp = -30.0f;



    public float Sensitivity => sensitivity;
    public bool LockCameraPosition => lockCameraPosition;
    public float CameraAngleOverride => cameraAngleOverride;
    public float TopClamp => topClamp;
    public float BottomClamp => bottomClamp;


    /// <summary>
    /// Pass an angle that will be limited to 360
    /// and clamped to max and min angle
    /// </summary>
    public float ClampAngle(float lfAngle, float lfMin, float lfMax)
    {
        if (lfAngle < -360f) lfAngle += 360f;
        if (lfAngle > 360f) lfAngle -= 360f;
        return Mathf.Clamp(lfAngle, lfMin, lfMax);
    }
}
