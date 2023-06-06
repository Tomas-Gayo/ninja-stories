using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "HasToWait", menuName = "Scriptable Objects/FSM/Decisions/HasToWait")]
public class HasToWait : Decision
{
    [SerializeField] private float waitTime;

    float timer = 0;

    public override bool Decide(BaseStateMachine stateMachine)
    {
        timer += Time.deltaTime;

        if (timer > waitTime)
        {
            timer = 0;
            return false;
        }

        return true;
    }
}

