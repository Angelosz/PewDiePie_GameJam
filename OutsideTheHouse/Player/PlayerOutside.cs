using UnityEngine;
using System.Collections;

public class PlayerOutside : MonoBehaviour 
{
	public int healthPoints;

	void Start()
	{
		healthPoints = 3;
	}

	public void ReceiveDamage()
	{
		healthPoints--;
		Debug.Log(healthPoints);
	}
}
