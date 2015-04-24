using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

	public void LoadScene(int level)
	{
		Application.LoadLevel (level);				// Loads the selected level on click. Level order is defined by the build order
	}
}
