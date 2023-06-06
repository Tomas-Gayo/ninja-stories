using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class HUDManager : MonoBehaviour
{
    [Header("Dependencies")]
    public HealthUI healthUI;

	public void UpdateHealthBar(HealthSO healthSO)
    {
        healthUI.RefreshHealthBarUI(healthSO.CurrentHealthNormalized);
    }
}
