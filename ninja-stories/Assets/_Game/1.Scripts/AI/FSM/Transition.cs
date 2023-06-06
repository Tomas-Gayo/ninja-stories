using UnityEngine;

[System.Serializable]
public class Condition
{
    public Decision decision;
    public bool result;
}

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "Transition", menuName = "Scriptable Objects/FSM/Transition")]
public class Transition : ScriptableObject
{
    public BaseState toState;
    public Condition[] conditions;

    bool[] expectedResult;
    bool[] actualResult;

    public void OnUpdate(BaseStateMachine stateMachine)
    {
        expectedResult = new bool[conditions.Length];
        actualResult = new bool[conditions.Length];

        for (int i = 0; i < expectedResult.Length; i++)
        {
            expectedResult[i] = conditions[i].result;
        }


        for (int i = 0; i < actualResult.Length; i++)
        {
            actualResult[i] = conditions[i].decision.Decide(stateMachine);
        }

        if (IsTheSameArray(expectedResult, actualResult))
        {
            stateMachine.ChangeState(toState);
        }
    }

    bool IsTheSameArray(bool[] firstArray, bool[] secondArray)
    {
        if (firstArray.Length != secondArray.Length)
            return false;

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
                return false;
        }

        return true;
    }
}
