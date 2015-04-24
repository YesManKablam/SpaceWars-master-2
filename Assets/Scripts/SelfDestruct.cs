using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

	public float timer = 1f;
	public int score = 0;

	void Update () {

		timer -= Time.deltaTime;
		if(timer <= 0) 
		{
			Destroy(gameObject);				// Timer to destroy objects. Used for things like bullets or enemies that could leave the playable area. Avoids the system from running out of memory.
		}
	}

	void OnCollisionEnter2D(){
		score ++;
	}

}
