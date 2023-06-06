using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NewLoadingScreenAnimatorParamSO", menuName = "Scriptable Objects/LoadingScreenAnimatorParamSO")]
public class LoadingScreenAnimatorParamSO : AnimatorParamBaseSO
{
    [SerializeField] private string showParamName;
    [SerializeField] private string hideParamName;

    public int ShowParamName => ConvertStringToHash(showParamName);
    public int HideParamName => ConvertStringToHash(hideParamName);
}
