using UnityEngine;
using System.Collections;

public class DoNotDestroy : MonoBehaviour {

	void Awake()
	{
		DontDestroyOnLoad (gameObject);			// This makes sure that elements are not deleted upon a scene load. Very helpfull for keeping music between scenes
	}
}
