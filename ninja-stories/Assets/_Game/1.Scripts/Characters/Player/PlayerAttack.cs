using System.Collections;
using UnityEngine;


/// <summary>
/// 
/// </summary>
[RequireComponent(typeof(Animator))]
public class PlayerAttack : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private InputReader inputReader = default;


    // State machine references 
    public bool InCombatState {get; private set; }
    public bool SheatheUnsheathe {get; set; }
    public bool HasAttacked {get; set; }
    public bool HasSpecialAttacked {get; set; }


    #region Listeners
    private void OnEnable()
    {
        inputReader.AttackEvent += OnAttack;
        inputReader.SpecialAttackEvent += OnSpecialAttack;
        inputReader.SheatheUnsheatheEvent += OnSheatheUnsheathe;
    }

    private void OnDisable()
    {
        inputReader.AttackEvent -= OnAttack;
        inputReader.SpecialAttackEvent -= OnSpecialAttack;
        inputReader.SheatheUnsheatheEvent -= OnSheatheUnsheathe;
    }
    #endregion

    private void OnSheatheUnsheathe()
    {
        SheatheUnsheathe = true;
        InCombatState = !InCombatState;
    }

    private void OnAttack()
    {       
        if (InCombatState && !HasAttacked)
        {
            //animator.SetTrigger(attackID);
            HasAttacked = true;
        }
    }

    private void OnSpecialAttack()
    {
        if (InCombatState && !HasSpecialAttacked)
        {
            //animator.SetTrigger(specialAttackID);
            HasSpecialAttacked = true;
        }
    }
}
