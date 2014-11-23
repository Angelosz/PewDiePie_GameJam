using UnityEngine;
using System.Collections;

public class LightAlarm : MonoBehaviour 
{
	private Alarm alarm;
	private bool alarmed = false;

	void Start()
	{
		alarm = GameObject.FindGameObjectWithTag("GameController").GetComponent<Alarm>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Player")
		{
			AlarmEveryone();
		}
	}

	private void AlarmEveryone()
	{
		if (!alarmed)
		{
			alarm.AlarmEveryYoutuber();
			alarmed = true;
		}
	}
}
