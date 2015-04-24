using UnityEngine;
using System.Collections;

public class FourWayMovement : MonoBehaviour {

	float shipBoundaryRadius = 0.5f;
	public float maxSpeed = 5f;

	void Update () {
		Vector3 pos = transform.position;
		pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
		pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
		transform.position = pos;
	
		if(pos.y+shipBoundaryRadius > Camera.main.orthographicSize) 
		{
			pos.y = Camera.main.orthographicSize - shipBoundaryRadius;				// Stops the player from leaving the camera's view.
		}

		if(pos.y-shipBoundaryRadius < -Camera.main.orthographicSize) 
		{
			pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
		}

		float screenRatio = (float)Screen.width / (float)Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;

		if(pos.x+shipBoundaryRadius > widthOrtho)
		{
			pos.x = widthOrtho - shipBoundaryRadius;
		}

		if(pos.x-shipBoundaryRadius < -widthOrtho) 
		{
			pos.x = -widthOrtho + shipBoundaryRadius;
		}
		transform.position = pos;
	}
}