using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour {

	public int damage = 0;
	public int scores = 0;


	void OnCollisionEnter2D(){
		damage += 1;
		scores++;
		if (damage >= 3) {
			Destroy (gameObject);
		}
	}
}
