using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// Controls the UI of the Health Bar
/// It is independent from other components and
/// only takes orders from a specific request
/// </summary>
public class HealthUI : MonoBehaviour
{
	[Header("Configuration")]
	[SerializeField, Tooltip("Time that last the bar to lerp")]
	private float lerpTime;

	[Header("Dependencies")]
	public Image health;

	// References
	float targetHealth; // Final value for the interpolation
	bool hasToUpdate = false;
	float currentLerpTime;

	private void Start()
	{
		health.fillAmount = 1;
	}

	private void Update()
	{
		if (hasToUpdate)
		{
			// Increment timer once per frame
			currentLerpTime += Time.deltaTime;
			if (currentLerpTime > lerpTime)
				currentLerpTime = lerpTime;

			// Is HealthBar already updated?
			if (IsHealthBarReady())
			{
				hasToUpdate = false;
				health.fillAmount = targetHealth;
				currentLerpTime = 0f;
			}

			// Interpolate 'til health target
			float perc = currentLerpTime / lerpTime;
			health.fillAmount = Mathf.Lerp(health.fillAmount, targetHealth, perc);

			// Depending on the amount of health colour will vary
			if (targetHealth < 0.5f)
			{
				health.color = Color.Lerp(health.color, Color.red, perc);
			}
			else if (targetHealth >= 0.5f)
			{
				health.color = Color.Lerp(health.color, Color.green, perc);
			}
		}
	}

	private bool IsHealthBarReady()
	{
		return Mathf.Round(health.fillAmount * 100) == Mathf.Round(targetHealth * 100);
	}

    #region Listener Events
    public void InitializeHealthBarUI(int initialHealth)
	{
		health.fillAmount = initialHealth;
	}
	
	public void RefreshHealthBarUI(float refreshValue)
	{
		hasToUpdate = true;
		targetHealth = refreshValue;
	}
	#endregion

}
