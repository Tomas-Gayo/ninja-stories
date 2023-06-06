using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "InventoryItemSlotConfig", menuName = "Scriptable Objects/Config/InventoryItemSlotConfig")]
public class InventoryItemSlotConfig : ScriptableObject
{
    [Header("Icon disabled configuration")]
    [SerializeField] private Sprite disabledIcon;
    [SerializeField] private Color disabledColorIcon;

    [Header("Icon default configuration")]
    [SerializeField] private Color defaultColorIcon;

    [Space]
    [Header("Counter disabled configuration")]
    [SerializeField] private int disabledCounterValue;
    [SerializeField] private Color disabledColorCounter;

    [Header("Counter default configuration")]
    [SerializeField] private Color defaultColorCounter;

    public void SetDisabledInventorySlotConfig(Image icon, TextMeshProUGUI counter)
    {
        icon.sprite = disabledIcon;
        icon.color = disabledColorIcon;

        counter.text = disabledCounterValue.ToString();
        counter.color = disabledColorCounter;
    }

    public void SetDefaultInventorySlotConfig(Image icon, TextMeshProUGUI counter)
    {
        icon.color = defaultColorIcon;
        counter.color = defaultColorCounter;
    }
}
