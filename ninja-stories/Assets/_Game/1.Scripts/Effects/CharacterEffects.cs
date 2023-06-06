using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class CharacterEffects : MonoBehaviour
{
	[SerializeField] private ParticleSystem steps;
	[SerializeField] private ParticleSystem hit;

	public void PlayStepsEffect()
	{
		steps.Play();
	}

	public void PlayHitEffect() => hit.Play();
}
