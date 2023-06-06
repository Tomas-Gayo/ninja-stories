using UnityEngine;

	
/// <summary>
/// Manage the weapons the player is holding 
/// It has the events to switch weapons or sheathe/unsheathe
/// </summary>
public class WeaponHolderManager : MonoBehaviour
{
    [Header("Weapons"), Tooltip("This can be empty, fullfill if you want a weapon by default in the player at the start.")]
    public WeaponSO currentLeftHandWeapon;
    public WeaponSO currentRightHandWeapon;

    WeaponHolder leftHandHolder;
    WeaponHolder rightHandHolder;

    WeaponHolder leftHandBackHolder;
    WeaponHolder rightHandBackHolder;

    private void Awake()
    {
        FindWeaponHolders();

        if (currentLeftHandWeapon != null)
        {
            SheatheWeaponEvent(currentLeftHandWeapon, currentRightHandWeapon);
        }
    }

    public void SheatheWeaponAnimationEvent()
    {
        SheatheWeapon(currentLeftHandWeapon.Weapon, currentRightHandWeapon.Weapon);
    }

    public void UnsheatheWeaponAnimationEvent()
    {
        UnsheatheWeapon(currentLeftHandWeapon.Weapon, currentRightHandWeapon.Weapon);
    }

    public void SheatheWeaponEvent(WeaponSO leftHandWeapon, WeaponSO rightHandWeapon)
    {
        if (leftHandWeapon == null && rightHandWeapon == null)
        {
            SheatheWeapon(currentLeftHandWeapon.Weapon, currentRightHandWeapon.Weapon);
        }
        else
        {
            SheatheWeapon(leftHandWeapon.Weapon, rightHandWeapon.Weapon);

            currentLeftHandWeapon = leftHandWeapon;
            currentRightHandWeapon = rightHandWeapon;
        }
    }

    public void UnsheatheWeaponEvent(WeaponSO leftHandWeapon, WeaponSO rightHandWeapon)
    {
        if (leftHandWeapon == null && rightHandWeapon == null)
        {
            UnsheatheWeapon(currentLeftHandWeapon.Weapon, currentRightHandWeapon.Weapon);
        } 
        else
        {
            UnsheatheWeapon(leftHandWeapon.Weapon, rightHandWeapon.Weapon);

            currentLeftHandWeapon = leftHandWeapon;
            currentRightHandWeapon = rightHandWeapon;
        }
    }

    private void SheatheWeapon(GameObject leftHandWeapon, GameObject rightHandWeapon)
    {
        leftHandHolder.LoadWeapon(null);
        rightHandHolder.LoadWeapon(null);
        leftHandBackHolder.LoadWeapon(leftHandWeapon);
        rightHandBackHolder.LoadWeapon(rightHandWeapon);
    }

    private void UnsheatheWeapon(GameObject leftHandWeapon, GameObject rightHandWeapon)
    {
        leftHandHolder.LoadWeapon(leftHandWeapon);
        rightHandHolder.LoadWeapon(rightHandWeapon);
        leftHandBackHolder.LoadWeapon(null);
        rightHandBackHolder.LoadWeapon(null);
    }
    
    private void FindWeaponHolders()
    {
        WeaponHolder[] weaponHolders = GetComponentsInChildren<WeaponHolder>();
        foreach (WeaponHolder weaponHolder in weaponHolders)
        {
            if (weaponHolder.IsBackPosition)
            {
                if (weaponHolder.IsLeftHand)
                {
                    leftHandBackHolder = weaponHolder;
                }
                else if (weaponHolder.IsRightHand)
                {
                    rightHandBackHolder = weaponHolder;
                }
            }
            else
            {
                if (weaponHolder.IsLeftHand)
                {
                    leftHandHolder = weaponHolder;
                }
                else if (weaponHolder.IsRightHand)
                {
                    rightHandHolder = weaponHolder;
                }
            }
        }
    }
}
