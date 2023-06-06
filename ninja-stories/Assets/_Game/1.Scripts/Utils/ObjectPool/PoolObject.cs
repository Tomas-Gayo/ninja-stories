using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public abstract class PoolObject : MonoBehaviour
{
	public abstract void Init();
	public abstract void Release();
}
