using UnityEngine;
using ScriptableObjectArchitecture;
	
/// <summary>
/// Sends the first selected element of the UI throught a channel
/// To whom is listening (Event System)
/// </summary>
public class FirstElementSelected : MonoBehaviour
{
	public GameObject firstElement;
	public GameObjectGameEvent firstElementChannel;

	public void SetFirstElementUI()
    {
		firstElementChannel?.Raise(firstElement);
    }
}
