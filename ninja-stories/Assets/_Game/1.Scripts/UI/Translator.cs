using UnityEngine;
using UnityEngine.Localization;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "Translator", menuName = "Scriptable Objects/Translator")]
public class Translator : ScriptableObject
{
    [SerializeField] private string tableReference;

    private LocalizedString translation;

    public LocalizedString GetTranslation(string tableEntryReference)
    {

        translation = new LocalizedString { 
            TableReference = tableReference, 
            TableEntryReference = tableEntryReference 
        };

        return translation;
    }

        
}
