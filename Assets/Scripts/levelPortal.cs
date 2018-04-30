using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelPortal : MonoBehaviour {

	public GameObject mapGenerator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		
	}

	void OnTriggerEnter2D (Collider2D other) {
         if (other.gameObject.tag == "Player") {
            Debug.Log ("Collision - fire portal");
			MapGenerator mapGen = mapGenerator.GetComponent<MapGenerator>();
			mapGen.GenerateMap();
         }
     }
}
