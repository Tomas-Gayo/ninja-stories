using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class WeaponHolder : MonoBehaviour
{
	[SerializeField, Tooltip("Transform of the weapon holder")]
	private Transform parentOverride;

	[SerializeField, Tooltip("Whether is left hand or not")]
	private bool isLeftHand;
	[SerializeField, Tooltip("Whether is right hand or not")]
	private bool isRightHand;
	[SerializeField, Tooltip("Whether the weapon is in sheathe position")]
	private bool isBackPosition;

	private GameObject currentWeapon;

	public bool IsLeftHand => isLeftHand;
	public bool IsRightHand => isRightHand;
	public bool IsBackPosition => isBackPosition;


	public void LoadWeapon(GameObject weaponToLoad)
    {
		UnloadAndDestroyWeapon();

		if (weaponToLoad == null)
        {
			return;
        }
        else
        {
			GameObject weapon = Instantiate(weaponToLoad);

			if (parentOverride != null)
            {
				weapon.transform.SetParent(parentOverride.transform, false);
            }
			else
            {
				Debug.Log("Please, provide a parent transform to attach the weapon.");
				return;
            }

			weapon.transform.localPosition = Vector3.zero;
			weapon.transform.localRotation = Quaternion.identity;
			weapon.transform.localScale = Vector3.one;

			currentWeapon = weapon;
		}	
    }

	private void UnloadAndDestroyWeapon()
    {
		if (currentWeapon != null)
		{
			Destroy(currentWeapon);
			currentWeapon = null;
		}
    }

	public void EnableWeaponCollider(bool enable)
    {
		Collider collider = GetComponentInChildren<Collider>();

		if (collider == null)
        {
			Debug.LogError("No Collider on weapon");
			return;
		}
			

		if (enable)
			collider.enabled = true;
        else
			collider.enabled = false;
    }
}
