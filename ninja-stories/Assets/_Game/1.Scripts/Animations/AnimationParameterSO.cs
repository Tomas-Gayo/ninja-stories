using UnityEngine;

/// <summary>
/// Keeps an animation parameter an can be returned as a hash parameter.
/// A hash parameters is an int value that identifies the parameter an only one.
/// This is useful for optimization.
/// </summary>
[CreateAssetMenu(fileName = "AnimationParameterSO", menuName = "Scriptable Objects/AnimationParam/Animation Parameter")]
public class AnimationParameterSO : AnimatorParamBaseSO
{
    [SerializeField] private string paramName;

    public int ParamName => ConvertStringToHash(paramName);

}
