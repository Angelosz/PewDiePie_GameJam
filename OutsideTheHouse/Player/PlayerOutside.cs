using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerOutside : MonoBehaviour 
{
	public int healthPoints;

	public void ReceiveDamage()
	{
		this.GetComponent<ChangeMaterial>().ChangeMaterialToRed();
		healthPoints--;
		if (healthPoints <= 0)
		{
			Application.LoadLevel("Outside");
		}
	}
}
