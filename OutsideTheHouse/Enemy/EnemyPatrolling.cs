using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class EnemyPatrolling : MonoBehaviour
{
	public GameObject wayPoint1;
	public GameObject wayPoint2;
	private GameObject currentWayPoint;
	private Enemy myEnemyScriptEnemy;

	void Start()
	{
		currentWayPoint = wayPoint1;
		myEnemyScriptEnemy = GetComponent<Enemy>();
	}

	void Update () {
		if (GetComponent<Enemy>().patrolling)
			MoveTowardsPlayer(currentWayPoint.transform.position);
	}

	private void MoveTowardsPlayer(Vector3 wayPointPosition)
	{
		if (Vector3.Distance(transform.position, wayPointPosition) > 1)
			transform.position = Vector3.MoveTowards(transform.position, wayPointPosition, myEnemyScriptEnemy.getSpeed());
		else
			currentWayPoint = (currentWayPoint == wayPoint1) ? wayPoint2 : wayPoint1;
	}
}
