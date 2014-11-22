using UnityEngine;
using System.Collections;

public class Alarm : MonoBehaviour
{
	public GameObject[] youtubers;

	public void AlarmEveryYoutuber()
	{
		foreach (GameObject youtuber in youtubers)
		{
			if (youtuber != null)
			{
				youtuber.GetComponent<Enemy>().patrolling = false;
			}
		}
	}
}