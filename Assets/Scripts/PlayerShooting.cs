using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	public Vector3 bulletOffset = new Vector3(0, 1f, 0);
	public GameObject bulletPrefab;
	int bulletLayer;

	public float fireDelay = 0.50f;
	float cooldownTimer = 0;

	void Start()
	{
		bulletLayer = gameObject.layer;
	}
	
	void Update () {
		cooldownTimer -= Time.deltaTime;

		if( Input.GetButton("Fire1") && cooldownTimer <= 0 ) 
		{
			cooldownTimer = fireDelay;
			Vector3 offset = transform.rotation * bulletOffset;
			GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);		// When the Fire1 button is pressed, which is set in unity's settings, a bullet prefab is created in the gameworld.
			bulletGO.layer = bulletLayer;
			audio.Play ();
		}
	}
}
