using UnityEngine;
using UnityEngine.Events;

	
public class PauseMenuManager : MonoBehaviour
{
	[SerializeField] private InputReader inputReader;

    [SerializeField] private UnityEvent OnOpenPauseMenu;
    [SerializeField] private UnityEvent onClosePauseMenu;

    private void OnEnable()
    {
        inputReader.OpenPauseMenuEvent += OpenPauseMenu;
    }

    private void OnDisable()
    {
        inputReader.OpenPauseMenuEvent -= OpenPauseMenu;
        inputReader.ClosePauseMenuEvent -= ClosePauseMenu;
    }

    private void OpenPauseMenu()
    {
        inputReader.OpenPauseMenuEvent -= OpenPauseMenu;
        OnOpenPauseMenu.Invoke();
        inputReader.ClosePauseMenuEvent += ClosePauseMenu;
    }

    private void ClosePauseMenu()
    {
        inputReader.ClosePauseMenuEvent -= ClosePauseMenu;
        onClosePauseMenu.Invoke();
        inputReader.OpenPauseMenuEvent += OpenPauseMenu;
    }
}
