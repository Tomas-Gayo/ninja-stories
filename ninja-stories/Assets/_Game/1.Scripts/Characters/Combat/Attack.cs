using UnityEngine;


/// <summary>
/// Add this script to the attacker, then be sure to add a damagable component in the 
/// object that will reveive the attack. With a collider on each part, once they collide 
/// the action will be triggered. Friendly fire is avoided when tags are the same. 
/// </summary>
public class Attack : MonoBehaviour
{
	[Header("Config")]
	[SerializeField] private AttackConfigSO baseAttackSO;

    private void OnTriggerEnter(Collider other)
    {

		if (!other.gameObject.CompareTag(gameObject.tag))
		{
			Damageable d = other.gameObject.GetComponentInParent<Damageable>();

			if (d != null)
			{
				d.ReceiveDamage(baseAttackSO.BaseAttack);
			}
		}
	}
}
