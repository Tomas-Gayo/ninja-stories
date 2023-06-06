using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class QuestSORequestReference : BaseReference<QuestSORequest, QuestSORequestVariable>
	{
	    public QuestSORequestReference() : base() { }
	    public QuestSORequestReference(QuestSORequest value) : base(value) { }
	}
}