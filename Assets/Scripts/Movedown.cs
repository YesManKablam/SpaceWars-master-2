using UnityEngine;
using System.Collections;

public class Movedown : MonoBehaviour {
	
	public float maxSpeed = 1f;
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position; 										// Moves the object to position		
		Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0); 		// Calc speed of the movement
		pos += (transform.rotation * velocity) * -1; 							// Updates position by the negative
		transform.position = pos; 												// Moves 
	}
}
