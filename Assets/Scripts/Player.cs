using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Rigidbody rgdbody;
	Vector3 velocity;
	
	void Start () {
		rgdbody = GetComponent<Rigidbody> ();
	}

	void Update () {
		velocity = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized * 10;
	}

	void FixedUpdate() {
		rgdbody.MovePosition (rgdbody.position + velocity * Time.fixedDeltaTime);
	}
}
