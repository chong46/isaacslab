﻿using UnityEngine;
using System.Collections;

public class Mechanics : MonoBehaviour {
	public Vector3 velocity = new Vector3 (0, 0, 0);

	public bool enableMotion = false;
    public Vector3 gravity = new Vector3(0, -9.8f, 0);
    public Vector3 handForce = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {

		velocity.x = 5f;
		velocity.y = 10f;

	}

	void reset(string Test) {
		Debug.Log ("RESET");
		velocity.x = 5f;
		velocity.y = 10f;
		this.transform.localPosition = Vector3.zero;
		Debug.Log (Test);
	
	}

	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown("space"))
			enableMotion = !enableMotion;

		if (Input.GetKeyDown ("r")) {
			reset ("test");
		}

		if (enableMotion) {
			// v = v0 + at
			velocity.y += Time.deltaTime * -9.8f;


			this.transform.Translate (velocity * Time.deltaTime);
		}
	}
}
