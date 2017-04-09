using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coll : MonoBehaviour {

	public GameObject explosion;

	void OnCollisionEnter(Collision col)
	{
		Ball ball = col.gameObject.GetComponent<Ball>();
		if (ball != null) {
			var boom = Instantiate (explosion, new Vector3(21.3f, 5f, transform.position.z), transform.rotation);

			Destroy (boom, 1f);
		}
	}

}
