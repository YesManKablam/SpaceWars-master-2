using UnityEngine;
using System.Collections;

public class Hide : MonoBehaviour {

	public GameObject menu;

	void Start()
	{
		menu.GetComponent<CanvasGroup> ().alpha = 0f;				// Hides the menu by making it transparent
	}
}
