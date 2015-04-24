using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CurrentScore : EnemySpawnDynamic {

	public Text scorecurr;
	public Text scorehigh;
	public int tempScore;
	public int tempHigh;

	void Start () {
		if(!PlayerPrefs.HasKey("highScore"))																// Initial check to see if the file for highscore exists or not
		{																
			PlayerPrefs.SetInt ("highScore", 0);															// If it does not, it gets created
		}

		tempScore = PlayerPrefs.GetInt("currentScore");														// Asigns the current score saved in currentScore to a temporary int
		tempHigh = PlayerPrefs.GetInt ("highScore");														// Same as above, but with the highscore file

		if(tempScore > tempHigh)																			// Checks the current against the highscore 
		{
			PlayerPrefs.SetInt("highScore", tempScore);														// And if it returns true, the current score value overwrites the highscore
		}

																											
		scorecurr.text = "It took " + tempScore.ToString () + " enemies to kill you.";						// This then writes out a message to a GUI label on the screen with your score
		scorehigh.text = "The highest amount it ever took to stop you was: " + tempHigh.ToString ();		// And this writes out the high score. This is done at the end in case you set a new high score
	}
}
