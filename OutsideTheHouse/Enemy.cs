using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
	public GameObject player;
	public bool patrolling = true;
	public int speed;
	public int healthpoints;

	public float getSpeed()
	{
		return speed * Time.deltaTime;
	}

	public void ReceiveDamge()
	{
		healthpoints--;
	}
}
