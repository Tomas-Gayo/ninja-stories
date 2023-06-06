using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class ItemRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    private void Update()
    {
        RotateObject();
    }

    private void RotateObject()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
