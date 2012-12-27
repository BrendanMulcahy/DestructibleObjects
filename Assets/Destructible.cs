using UnityEngine;
using System.Collections;

public class Destructible : MonoBehaviour {
	
	public GameObject debrisPrefab;
	
	void OnCollisionEnter(Collision collision) {
		if (collision.impactForceSum.magnitude > 10f ) {
			DestroyMe ();
		}
	}
	
	void OnMouseDown() {
		DestroyMe();
	}
	
	void DestroyMe() {
		if (debrisPrefab) {
			Instantiate(debrisPrefab, transform.position, transform.rotation);
		}
		Destroy(gameObject);
	}
}
