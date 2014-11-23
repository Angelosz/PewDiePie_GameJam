using UnityEngine;
using System.Collections;

public class PlayerOutsideAttack : MonoBehaviour
{
	public GameObject attackRange;
	private float attackSpeed = 1.5f;
	private float timerAttackSpeed = 0;
	private bool canAttack;

	void Update()
	{
		if (!canAttack)
		{
			timerAttackSpeed += Time.deltaTime;
			if(timerAttackSpeed > attackSpeed)
				canAttack = true;
		}

		if (Input.GetButtonDown("Fire1"))
			if (canAttack)
			{
				AttackEnemies();
				canAttack = false;
				timerAttackSpeed = 0;
			}
	}

	private void AttackEnemies()
	{
		
	}
}
