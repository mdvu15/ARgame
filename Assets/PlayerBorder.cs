using UnityEngine;
using System.Collections;

public class PlayerBorder : MonoBehaviour {
	
	public ePlayer player;
	public ScoreUI score;

	void OnCollisionEnter(Collision col)
	{
		Ball ball = col.gameObject.GetComponent<Ball>();
		if (ball != null)
		{
			ball.transform.position = new Vector3(0f, ball.transform.position.y, 0f);

			if (player == ePlayer.AI) score.scoreHuman++;
			else if (player == ePlayer.Human) score.scoreAI++;
		}
	}
}
