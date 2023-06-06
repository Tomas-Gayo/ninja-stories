using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class GameInputs : MonoBehaviour
{
	[SerializeField] private InputReader inputReader;

	public void EnableGameplay()
    {
		inputReader.EnableGameplayInput();
    }

	public void EnableMenu()
    {
		inputReader.EnableMenuInput();
    }
}
