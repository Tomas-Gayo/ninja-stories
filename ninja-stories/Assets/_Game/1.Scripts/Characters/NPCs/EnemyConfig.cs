using UnityEngine;

public class EnemyConfig : MonoBehaviour
{
	[SerializeField] private EnemySO currentEnemy;
    [SerializeField] private EnemyKilledChannel enemyKilledChannel;

	public void UpdateEnemyQuest()
    {
        enemyKilledChannel.OnEnemyKilled(currentEnemy);
    }
}
