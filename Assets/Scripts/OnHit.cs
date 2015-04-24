using UnityEngine;
using System.Collections;

public class OnHit : MonoBehaviour {

	void OnCollisionEnter2D()
	{
		Destroy (gameObject);								// Anything that this is attached to will delete itself when it makes contact with anything
	}
}
