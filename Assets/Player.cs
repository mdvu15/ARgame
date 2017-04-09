using UnityEngine;
using System.Collections;


public enum ePlayer
{
	Human,
	AI
}


public class Player : MonoBehaviour {
	public ePlayer player;
	void FixedUpdate () 
	{
		//inputSpeed = Input.GetAxisRaw("PlayerFront");
		//if (Camera.main.transform.position.z > -0.5 & Camera.main.transform.position.z < 0.5) {
		transform.position = new Vector3 (transform.position.x, transform.position.y, Camera.main.transform.position.z);
		//} //else if (Camera.main.transform.position.z < -0.5) {
			//transform.position = new Vector3 (transform.position.x, transform.position.y, -0.5f);
		//} else {
		//	transform.position = new Vector3 (transform.position.x, transform.position.y, 0.5f);
		//}
	}
}
