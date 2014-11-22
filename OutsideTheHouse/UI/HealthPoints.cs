using System.Runtime.Serialization.Formatters;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthPoints : MonoBehaviour
{
	public Sprite fullHeart;
	public Sprite emptyHeart;
	public GameObject player;
	public int hp;

	void Update()
	{
		this.GetComponent<Image>().sprite = (player.GetComponent<PlayerOutside>().healthPoints >= hp) ? fullHeart : emptyHeart;
	}
}
