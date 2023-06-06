using UnityEngine;

/// <summary>
/// Return the hash parameter of the player animator
/// </summary>
[CreateAssetMenu(fileName = "NewCharacterAnimations", menuName = "Scriptable Objects/AnimationParam/Character Animations")]
public class CharacterAnimatorParamSO : AnimatorParamBaseSO
{
    [SerializeField] private string isMovingParamName;
    [SerializeField] private string runParamName;
    [SerializeField] private string jumpParamName;
    [SerializeField] private string inAirParamName;
    [SerializeField] private string isGroundedParamName;
    [SerializeField] private string attackParamName;
    [SerializeField] private string specialAttackParamName;
    [SerializeField] private string getHitParamName;
    [SerializeField] private string isDeadParamName;
    [SerializeField] private string sheatheParamName;
    [SerializeField] private string unsheatheParamName;

    public int IsMovingParamName => ConvertStringToHash(isMovingParamName);
    public int RunParamName => ConvertStringToHash(runParamName);
    public int JumpParamName => ConvertStringToHash(jumpParamName);
    public int InAirParamName => ConvertStringToHash(inAirParamName);
    public int IsGroundedParamName => ConvertStringToHash(isGroundedParamName);
    public int AttackParamName => ConvertStringToHash(attackParamName);
    public int SpecialAttackParamName => ConvertStringToHash(specialAttackParamName);
    public int GetHitParamName => ConvertStringToHash(getHitParamName);
    public int IsDeadParamName => ConvertStringToHash(isDeadParamName);
    public int SheatheParamName => ConvertStringToHash(sheatheParamName);
    public int UnsheatheParamName => ConvertStringToHash(unsheatheParamName);

}
