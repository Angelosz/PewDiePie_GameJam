using System.Security.Policy;
using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
	public GameObject keyImage;
	private bool hasKey = false;

	private void getKey()
	{
		hasKey = true;
		keyImage.GetComponent<Key>().changeKey();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Key")
		{
			getKey();
			Destroy(other.gameObject);
		}

		if (other.transform.tag == "Door" && hasKey)
			Application.LoadLevel("Inside");
	}
}
