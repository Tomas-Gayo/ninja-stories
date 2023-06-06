using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "EnemyKilledChannel", menuName = "Scriptable Objects/Quests/Enemy Killed Channel")]
public class EnemyKilledChannel : ScriptableObject
{
    public event UnityAction<EnemySO> UpdateEnemyQuest = delegate { };

    public void OnEnemyKilled(EnemySO enemySO)
    {
        UpdateEnemyQuest.Invoke(enemySO);
    }
}
