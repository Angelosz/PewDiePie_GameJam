using UnityEngine;

public class EnemyAttack : MonoBehaviour 
{
	private Enemy myEnemyScriptEnemy;
	private float attackSpeed;
	private float attackSpeedTimer;

	void Start()
	{
		attackSpeed = 2f;
		attackSpeedTimer = 0;
		myEnemyScriptEnemy = this.GetComponent<Enemy>();
	}

	void Update()
	{
		if (!myEnemyScriptEnemy.patrolling)
			if(CheckAttackSpeed())
				CheckDistance();
	}

	private void CheckDistance()
	{
		if (Vector3.Distance(this.transform.position, myEnemyScriptEnemy.player.transform.position) < 1.6f)
			AttackPlayer();
	}

	private void AttackPlayer()
	{
		myEnemyScriptEnemy.player.GetComponent<PlayerOutside>().ReceiveDamage();
	}

	private bool CheckAttackSpeed()
	{
		attackSpeedTimer += Time.deltaTime;
		if (attackSpeedTimer > attackSpeed)
		{
			attackSpeedTimer = 0;
			return true;
		}
		return false;
	}
}
