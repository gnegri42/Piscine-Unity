using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public GameObject	ball;
	public GameObject	club;
	
	private float		speed;
	// Use this for initialization
	void Start () {
		speed = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("space") && speed <= 0.5f)
			speed += 0.05f;
		if (club.transform.localPosition.y >= 1 && ball.transform.position.y <= 5.5) {
			if (speed >= 0) {
				ball.transform.Translate(Vector3.up * speed);
				speed -= 0.05f;
			}
		}
	}
}
