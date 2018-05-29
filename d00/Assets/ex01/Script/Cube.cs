using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
	public float	speed;
	
	// Use this for initialization
	void Start () {
		speed = Random.Range(0.05f, 0.1f);
	}

	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(Vector3.down * speed);
		if (gameObject.transform.position.y <= 0)
			Destroy(gameObject);
		
	}
}
