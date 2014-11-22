using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
	public Sprite key;

	public void changeKey()
	{
		this.GetComponent<Image>().sprite = key;
	}
}
