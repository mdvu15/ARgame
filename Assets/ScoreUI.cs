using UnityEngine;
using System.Collections;


public class ScoreUI : MonoBehaviour {
	
	public int scoreHuman;
	public int scoreAI;
	public GUIStyle style;
	public int winningScore = 5;

	void OnGUI()
	{
		// calculate the top screen center of the screen
		float x = Screen.width/2f;
		float y = 30f;
		float width = 300f;
		float height = 20f;
		string text = scoreHuman + " | " + scoreAI;
		
		// draw the label at the top center of the screen
		GUI.Label(new Rect(x-(width/2f), y, width, height), text, style);

		// check for winning condition
		if (scoreHuman >= winningScore || scoreAI >= winningScore)
		{
			// disable ball
			GameObject ball = GameObject.Find("Ball");
			if (ball != null)
			{
				ball.SetActive(false);
			}


			string winMessage = "You won";
			if (scoreAI >= winningScore)
			{
				winMessage = "You lost";
			}
				
			y = Screen.height/2f;
			GUI.Label(new Rect(x-(width/2f), y+(height/2f), width, height), winMessage, style);
		}

	}
}
