using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("space") && gameObject.transform.localPosition.y <= 10)
			gameObject.transform.Translate(Vector3.down * 0.1f);
		else if (gameObject.transform.localPosition.y <= 0.9f)
		{
			gameObject.transform.Translate(Vector3.up * 0.3f);
			Debug.Log("global : " + gameObject.transform.position.y);
			Debug.Log("local : " + gameObject.transform.localPosition.y);
		}
		
	}
}
