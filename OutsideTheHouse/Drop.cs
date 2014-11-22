using UnityEngine;
using System.Collections;

public class Drop : MonoBehaviour
{
	public GameObject key;
	public void DropKey()
	{
		Instantiate(key, this.transform.position, Quaternion.identity);
	}
}
