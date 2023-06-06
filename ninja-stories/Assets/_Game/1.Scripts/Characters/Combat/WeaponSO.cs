using UnityEngine;

/// <summary>
/// SO to hold the weapon prefabs
/// </summary>
[CreateAssetMenu(fileName = "NewWeapon", menuName = "Scriptable Objects/Weapon")]
public class WeaponSO : ScriptableObject
{
    [SerializeField, Tooltip("Weapon prefab")]
    private GameObject weapon;

    public GameObject Weapon => weapon;
}
