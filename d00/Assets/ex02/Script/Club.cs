using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("space"))
			gameObject.transform.Translate(Vector3.down * 0.1f);
		else if (gameObject.transform.position.y <= 0.04)
		{
			gameObject.transform.Translate(Vector3.up * 0.1f);
			Debug.Log(gameObject.transform.position.y);
		}
		
	}
}
