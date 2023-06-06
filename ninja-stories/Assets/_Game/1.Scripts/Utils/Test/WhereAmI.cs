using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class WhereAmI : MonoBehaviour
{
    public int frameInterval;

    private void Update()
    {
        if (Time.frameCount % frameInterval == 0)
        {
            Debug.Log(transform.position);
        }
    }
}
