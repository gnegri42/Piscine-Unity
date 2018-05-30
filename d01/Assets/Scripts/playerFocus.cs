using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFocus : MonoBehaviour {
	public GameObject	p1;
	public GameObject	p2;
	public GameObject	p3;

	private Vector3		pos;
	private GameObject	current;	
	// Use this for initialization
	void Start () {
		pos = transform.position;
		current = p1;		
		pos.x = p1.transform.position.x;
		transform.position = pos;
	}
	
	// Update is called once per frame
	void Update () {

		//Align cam with selected player
		if (Input.GetKeyDown("1"))
			current = p1;
		if (Input.GetKeyDown("2"))
			current = p2;
			pos.x = p2.transform.position.x;
		if (Input.GetKeyDown("3"))
			current = p3;		
		pos.x = current.transform.position.x;
		transform.position = pos;
	}
}
