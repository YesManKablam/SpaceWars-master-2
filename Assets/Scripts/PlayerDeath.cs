using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {
	
	public int damage = 0;
	public float invul = 0;
	int startLayer;
	SpriteRenderer sr;
	public GameObject spawner;

	void Start (){
		startLayer = gameObject.layer;
		spawner = GameObject.Find ("EnemySpawn");
		sr = GetComponent<SpriteRenderer> ();
	}

	void OnCollisionEnter2D(){
		damage += 1;
		if (damage >= 3) {
			int currScore;
			currScore = spawner.GetComponent<EnemySpawnDynamic>().score;
			PlayerPrefs.SetInt("currentScore", currScore);									// Saves the players score to a file called currentScore. This is so that we can access it elsewhere, as the value gets destroyed along with everthing else here upon death
			Destroy (gameObject);
		}
	}
}

