using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

	private readonly int speed = 3;
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.Translate(new Vector3(Input.GetAxis("Horizontal") * 
			Time.deltaTime * speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed));
	}

	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("Choque!");
	}
}
