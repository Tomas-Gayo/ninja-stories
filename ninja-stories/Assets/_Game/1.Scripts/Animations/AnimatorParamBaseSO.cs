using UnityEngine;

/// <summary>
/// Base Class for ScriptableObjects of animations
/// </summary>
public class AnimatorParamBaseSO : ScriptableObject
{
    public int ConvertStringToHash(string parameter)
    {
        return Animator.StringToHash(parameter);
    }
}
