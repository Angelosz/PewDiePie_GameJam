using System;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class LightPostPatrol : MonoBehaviour
{
	public GameObject[] wayPoints;
	private GameObject currentWayPoint;

	void Start()
	{
		currentWayPoint = wayPoints[0];
	}

	void Update()
	{
		if (Vector3.Distance(transform.position, currentWayPoint.transform.position) > 1)
			transform.position = Vector3.MoveTowards(transform.position, currentWayPoint.transform.position, 3*Time.deltaTime);
		else
			currentWayPoint = wayPoints[new System.Random().Next(0, wayPoints.Length)];
	}
}
