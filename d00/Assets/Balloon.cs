using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {
	public GameObject	balloon;
	public int			souffle;
	private int			souffle_max;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space"))
        	balloon.transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
		else if (balloon.transform.localScale != new Vector3 (0, 0, 0))
			balloon.transform.localScale -= new Vector3 (0.05f, 0.05f, 0.05f);
		
	}
}
