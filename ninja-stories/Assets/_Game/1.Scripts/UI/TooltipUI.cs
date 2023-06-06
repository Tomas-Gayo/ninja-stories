using UnityEngine;
using TMPro;

	
/// <summary>
/// 
/// </summary>
public class TooltipUI : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI tooltipTitle;
	[SerializeField] private TextMeshProUGUI tooltipDescription;

	public void FillTooltip(string title, string description)
    {
		tooltipTitle.text = title;
		tooltipDescription.text = description;
    }

	public void CleanTooltip()
    {
		tooltipTitle.text = string.Empty;
		tooltipDescription.text = string.Empty;
    }
}
