using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	private float timer = 180;

	void Update()
	{
		timer -= Time.deltaTime;
		this.GetComponent<Text>().text = 
			((((int) timer/60) > 9) ? ((int) timer/60).ToString() : "0" + ((int) timer/60)) + ":" +
			((((int) timer%60) > 9) ? ((int) timer%60).ToString() : "0" + ((int) timer%60));
	}
}
