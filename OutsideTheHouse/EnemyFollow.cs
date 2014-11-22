using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
	private Enemy myEnemyScriptEnemy;
	private bool notBesidesHim = true;

	void Start()
	{
		myEnemyScriptEnemy = this.GetComponent<Enemy>();
	}

	void Update()
	{
		if (myEnemyScriptEnemy.patrolling)
			checkDistance();
		else
			followPlayer();
	}

	private void checkDistance()
	{
		if (Vector3.Distance(myEnemyScriptEnemy.player.transform.position, transform.position) < 7)
			myEnemyScriptEnemy.patrolling = false;
	}

	private void followPlayer()
	{
		checkIfBesides();
		if(notBesidesHim)
			transform.position = Vector3.MoveTowards(transform.position, myEnemyScriptEnemy.player.transform.position, myEnemyScriptEnemy.getSpeed());
	}

	private void checkIfBesides()
	{
		if (Vector3.Distance(myEnemyScriptEnemy.player.transform.position, transform.position) < 1.35f)
			notBesidesHim = false;
		else
			notBesidesHim = true;
	}
}
