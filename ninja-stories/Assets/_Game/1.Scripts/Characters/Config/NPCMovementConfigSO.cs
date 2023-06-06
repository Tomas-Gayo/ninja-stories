using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NPCMovementConfig", menuName = "Scriptable Objects/Config/NPC Movement Config")]
public class NPCMovementConfigSO : ScriptableObject
{
    [SerializeField, Tooltip("Walking speed of the NPC.")]
    private float walkSpeed;

    [SerializeField, Tooltip("Run speed of the NPC.")]
    private float runSpeed;

    [SerializeField, Tooltip("Rotation speed of the NPC.")]
    private float rotationSpeed;


    public float WalkSpeed => walkSpeed;
    public float RunSpeed => runSpeed;
    public float RotationSpeed => rotationSpeed;

}
