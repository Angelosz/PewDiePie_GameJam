using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms;

public class ChangeMaterial : MonoBehaviour
{
	public Material redMaterial;
	private Material ownMaterial;
	private float timer = 0;
	private bool damaged = false;

	void Start()
	{
		ownMaterial = this.renderer.material;
	}

	void Update()
	{
		if (damaged)
		{
			timer += Time.deltaTime;
			if (timer > 0.2f)
				ChangeMaterialToOwn();
		}
	}

	public void ChangeMaterialToRed()
	{
		this.renderer.material = redMaterial;
		damaged = true;
		timer = 0;
	}

	public void ChangeMaterialToOwn()
	{
		this.renderer.material = ownMaterial;
		damaged = false;
		timer = 0;
	}
}
