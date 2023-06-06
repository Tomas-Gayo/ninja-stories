using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class PlayerController : MonoBehaviour
{
	[SerializeField] private InputReader inputReader;

	public void EnableGameplayControll()
    {
		inputReader.EnableGameplayInput();
    }

	public void EnableMenuControll()
    {
		inputReader.EnableMenuInput();
    }

	public void DisableAllControlls()
    {
		inputReader.DisableAllInputs();
    }
}
