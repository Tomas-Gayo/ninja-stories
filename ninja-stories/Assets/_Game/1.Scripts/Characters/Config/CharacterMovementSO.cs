using UnityEngine;

/// <summary>
/// Config movevement data for the player character
/// </summary>
//[CreateAssetMenu(fileName = "CharacterMovement", menuName = "Scriptable Objects/Config/Character Movement Config")]
public class CharacterMovementSO : ScriptableObject
{
    [Header("Horitzontal Movement")]
    [SerializeField, Tooltip("The slowest speed a character can move")]
    private float walkSpeed;
    [SerializeField, Tooltip("The fastest speed a character can move")]
    private float runSpeed;
    [SerializeField, Tooltip("The force gravity applied to the character.")]
    private float gravity = -9.8f;

    [Space]
    [Header("Character Rotation")]
    [SerializeField, Tooltip("Turn speed of the character.")]
    private float rotationSpeed;
    [SerializeField, Tooltip("How fast the character turns to face movement direction.")]
    [Range(0.0f, 0.1f)]
    private float rotationSmoothTime;


    public float WalkSpeed => walkSpeed;
    public float RunSpeed => runSpeed;
    public float Gravity => gravity;
    
    public float RotationSpeed => rotationSpeed;
    public float RotationSmoothTime => rotationSmoothTime;

}
