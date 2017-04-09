using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public Vector3 initialImpulse;
	
	void Start () 
	{
		GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
	}
}
