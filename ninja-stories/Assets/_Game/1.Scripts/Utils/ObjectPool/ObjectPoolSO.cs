using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NewObjectPoolSO", menuName = "Scriptable Objects/ObjectPool")]
public class ObjectPoolSO : ScriptableObject
{
    private PoolObject poolObject;
    private List<PoolObject> pool;
    private Transform poolRoot;


    public void Init(int numberOfObjectsInPool, PoolObject objectToPool)
    {
        pool = new List<PoolObject>();
        poolObject = objectToPool;

        for(int i = 0; i < numberOfObjectsInPool; i++)
        {
            PoolObject instance = CreateInstance();
            
        }
    }

    private PoolObject CreateInstance()
    {
        PoolObject instance = Instantiate(poolObject);
        instance.gameObject.SetActive(false);
        instance.gameObject.transform.parent = poolRoot;
        pool.Add(instance);
        return instance;
    }

    public T Request<T>()
    {
        foreach (PoolObject poolObject in pool)
        {
            if (poolObject.gameObject.activeInHierarchy == false)
            {
                poolObject.gameObject.SetActive(true);
                return poolObject.gameObject.GetComponent<T>();
            }
        }

        // In case there is no space add extra instance
        var instance = CreateInstance();
        instance.gameObject.SetActive(true);
        return instance.gameObject.GetComponent<T>();
    }

    public void Return(PoolObject poolObject)
    {
        poolObject.gameObject.SetActive(false);
    }

    public void SetParent(Transform t)
    {
        poolRoot = t;
    }
}
