using UnityEngine;
using System.Collections;

public class EnemySpawnDynamic : MonoBehaviour {
	
	public GameObject enemy0;
	public GameObject enemy1;
	GameObject enemyInstance0;
	GameObject enemyInstance1;
	public int spawnLocation;
	public float timer; 
	public float difficulty = 60f;
	public GUIText Score;
	public int score;
	

	void Start(){
		PlayerPrefs.SetInt("currentScore", 0);			// Creates a file for your score.
		score = 0;
	}

	void spawn()
	{
		if (difficulty >= 50)
		{
			spawnLocation = Random.Range (1, 3);
			timer = 2;
		}

		else if (difficulty >= 40)
		{
			spawnLocation = Random.Range (1, 5);
			timer = 1;
		}

		else if (difficulty >= 30)
		{
			spawnLocation = Random.Range (3, 5);
			timer = 2;
		}

		else if (difficulty >= 20)
		{
			spawnLocation = Random.Range (3, 8);
			timer = 1;
		}

		else if (difficulty >= 10)
		{
			spawnLocation = Random.Range (5, 8);
			timer = 2;
		}

		else {
			spawnLocation = Random.Range (5, 8); // Random.Range is inclusive for min, and exclusive for max.
			timer = 1;
		}
		
		switch (spawnLocation) 
		{
		case 1:
			spawnPos0();
			break;
		case 2:
			spawnPos1();
			break;
		case 3:
			spawnPos2();
			break;
		case 4:
			spawnPos3();
			break;
		case 5:
			spawnPos4();
			break;
		case 6:
			spawnPos5();
			break;
		case 7:
			spawnPos6();
			break;
		case 8:
			spawnPos7();
			break;
		}
	}

	void spawnPos0 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (4, 10, -2), Quaternion.identity);
		score += 1;
	}

	void spawnPos1 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-4, 10, -2), Quaternion.identity);
		score += 1;
	}
	
	void spawnPos2 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (10, 4, -2), Quaternion.identity);
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-10, -4, -2), Quaternion.identity);
		score += 2;
	}
	
	void spawnPos3 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-4, -10, -2), Quaternion.identity);
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (4, 10, -2), Quaternion.identity);
		score += 2;
	}

	void spawnPos4 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (4, -10, -2), Quaternion.identity);
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (10, -4, -2), Quaternion.identity);
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-4, -10, -2), Quaternion.identity);
		score += 3;
	}

	void spawnPos5 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (10, 4, -2), Quaternion.identity);
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (4, 10, -2), Quaternion.identity);
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-10, 4, -2), Quaternion.identity);
		score += 3;
	}

	void spawnPos6 ()
	{
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-10, 4, -2), Quaternion.identity);
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-10, -4, -2), Quaternion.identity);
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (10, 4, -2), Quaternion.identity);
		enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (10, -4, -2), Quaternion.identity);
		score += 4;
	}

	void spawnPos7 ()
	{
		int enemy;
		enemy = Random.Range (1, 4);
		Debug.Log ("7");
		if (enemy == 1) {
			enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (4, 10, -2), Quaternion.identity);
			enemyInstance0 = (GameObject)Instantiate (enemy0, new Vector3 (-4, 10, -2), Quaternion.identity);
			score += 2;
		} else {
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (-4, 10, -2), Quaternion.identity); 
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (-2, 10, -2), Quaternion.identity); 
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (2, 10, -2), Quaternion.identity); 
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (4, 10, -2), Quaternion.identity); 
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (1, 8, -2), Quaternion.identity); 
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (3, 8, -2), Quaternion.identity); 
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (-3, 8, -2), Quaternion.identity); 
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (-1, 8, -2), Quaternion.identity); 
			enemyInstance1 = (GameObject)Instantiate (enemy1, new Vector3 (0, 6, -2), Quaternion.identity); 
			score += 9;
		}
	}
	
	void Update()
	{
		timer -= Time.deltaTime;
		difficulty -= Time.deltaTime;
		if (timer <= 0)
		{
			spawn ();
		}
	}	
}



// This script works with two timers counting down. The first one is a short delay between when each enemy spawns. once it runs out, it calls the spawn function
// The spawn function using the second timer. depending on how much time has passed, a different set of random numbers are generated. Those are used in a switch statement that calls a specific spawing patern 
// Each spawn pattern drops enemies at set locations on the map. It also increases the players score based on how many enemies are generated.