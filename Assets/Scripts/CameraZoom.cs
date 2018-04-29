using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {
	public int minZoom = 15;
	public int maxZoom = 50;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxis("Mouse ScrollWheel") > 0) {
			GetComponent<Camera>().orthographicSize--;
		}

		if (Input.GetAxis("Mouse ScrollWheel") < 0) {
			GetComponent<Camera>().orthographicSize++;
		}

		if (GetComponent<Camera>().orthographicSize < minZoom) {
			GetComponent<Camera>().orthographicSize = minZoom;
		}

		if (GetComponent<Camera>().orthographicSize > maxZoom) {
			GetComponent<Camera>().orthographicSize = maxZoom;
		}
	}
}
