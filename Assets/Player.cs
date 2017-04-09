using UnityEngine;
using System.Collections;


public enum ePlayer
{
	Front,
	Back
}


public class Player : MonoBehaviour {
	

	public float speed = 15f;
	public ePlayer player;

	void FixedUpdate () 
	{
		float inputSpeed = 0f;
		if (player == ePlayer.Front)
		{
			inputSpeed = Input.GetAxisRaw("PlayerFront");
		}
		else if (player == ePlayer.Back)
		{
			inputSpeed = Input.GetAxisRaw("PlayerBack");
		}

		transform.position += new Vector3(0f, 0f, inputSpeed * speed * Time.deltaTime);
	}
}
