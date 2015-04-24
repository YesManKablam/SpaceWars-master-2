using UnityEngine;
using System.Collections;

public class ScreenFix : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution (1200, 800, false); // Sets screen resolution and if fullscreen is on or not.
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
