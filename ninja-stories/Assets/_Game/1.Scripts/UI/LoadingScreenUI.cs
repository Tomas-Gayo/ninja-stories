using UnityEngine;
using ScriptableObjectArchitecture;

	
/// <summary>
/// Controls loading screen animator
/// </summary>
[RequireComponent(typeof(Animator))]
public class LoadingScreenUI : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private LoadingScreenAnimatorParamSO animSO;


    [SerializeField] private BoolGameEvent toggleLoadingScreenEvent = default;

    Animator animator;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void ToggleScreen(bool enable)
    {
        if (enable)
        {
            animator.SetTrigger(animSO.ShowParamName);
        }
        else
        {
            animator.SetTrigger(animSO.HideParamName);
        }
    }

    // Events animator triggers (Added in the animator)
    public void ShowLoadingScreenEndEvent()
    {
        toggleLoadingScreenEvent.Raise(true);
    }

    public void HideLoadingScreenEndEvent()
    {
        toggleLoadingScreenEvent.Raise(false);
    }

}
