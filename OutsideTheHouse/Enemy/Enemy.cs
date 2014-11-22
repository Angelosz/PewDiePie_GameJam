using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
	public GameObject player;
	public bool patrolling = true;
	public int speed;
	public int healthPoints;

	public float getSpeed()
	{
		return speed * Time.deltaTime;
	}

	public void ReceiveDamage()
	{
		healthPoints--;
		if (healthPoints <= 0)
		{
			if (this.GetComponent<Drop>() != null)
				this.GetComponent<Drop>().DropKey();
			Destroy(this.gameObject);
		}
			
	}


}
