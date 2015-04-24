using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

	public GameObject playerPrefab;
	GameObject playerInstance;
	float respawnTimer = 1;
	public int numDeath = -1;

	// Use this for initialization
	void Start () {
		spawnPlayer ();
	}

	void spawnPlayer()
	{
		numDeath ++;
		respawnTimer = 1;
		playerInstance = (GameObject)Instantiate (playerPrefab, transform.position, Quaternion.identity);
	}

	// Update is called once per frame
	void Update () {
		if (playerInstance == null) {
			respawnTimer -= Time.deltaTime;

			if(respawnTimer <= 0)
			{
				spawnPlayer();
			}

			if (numDeath == 3 )
			{
				Application.LoadLevel("_Scene_4");
			}
		}
	
	}
}
