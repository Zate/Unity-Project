using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2D : MonoBehaviour {

	//public float speed;
	private Rigidbody2D rb2d;

	private Vector3 startPos;

	

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		// startPos = mapGen.PlayerStart();
		// Debug.Log("playerx" + startPos.x );
	}

	void FixedUpdate()
	{
		// float moveHorizontal = Input.GetAxis ("Horizontal");
		// float moveVertical = Input.GetAxis ("Vertical");
		

		// Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		// rb2d.AddForce (movement * speed);
		// rb2d.AddForce (e.mousePosition * speed);
		if (Input.GetMouseButton(0)) {
			transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), 0.2f);
			//Lerp(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), 0.05f);
			
			Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
			difference.Normalize();
			// float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
			// transform.rotation = Quaternion.Euler(0f, 0f, rotation_z);
			Vector2 movement = new Vector2 (difference.x, difference.y);
			rb2d.AddForce (movement);
			
		}
		rb2d.velocity = new Vector2(0,0);
		
	}
}
