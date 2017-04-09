using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	public Vector3 initialImpulse;
	public float ballSpeed = 3.0f;
	public Rigidbody rb;
	
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(initialImpulse, ForceMode.Impulse);
	}

	//void FixedUpdate()
	//{
	//	transform.position += transform.forward * ballSpeed * Time.deltaTime;
	//}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Pick Up")) {
			other.gameObject.SetActive(false);
		}
	}
}
