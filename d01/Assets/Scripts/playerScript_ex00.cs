using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript_ex00 : MonoBehaviour {
	public float		jumpHeight;
	public playerScript_ex00 p1;
	public playerScript_ex00 p2;
	public playerScript_ex00 p3;

	private bool		isJumping = false;
	// Use this for initialization
	void Start () {
		p1.enabled = true;
		p2.enabled = false;
		p3.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		//Restart scene
		if (Input.GetKey("r"))
			Application.LoadLevel(Application.loadedLevel);

		//Move player
		if (Input.GetKey("left"))
			transform.Translate(Vector3.left * Time.deltaTime);
		if (Input.GetKey("right"))
			transform.Translate(Vector3.right * Time.deltaTime);
		if (Input.GetKeyDown("space") && !isJumping)
		{
			transform.Translate(Vector3.up * jumpHeight);			
			isJumping = true;
		}

		//Change player
		if (Input.GetKeyDown("1"))
		{
			p1.enabled = true;
			p2.enabled = false;
			p3.enabled = false;
		}
		if (Input.GetKeyDown("2"))
		{
			p2.enabled = true;
			p1.enabled = false;
			p3.enabled = false;
		}
		if (Input.GetKeyDown("3"))
		{
			p3.enabled = true;
			p1.enabled = false;
			p2.enabled = false;
		}
		
	}

	//Test if player is on ground
	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Player") {
			isJumping = false;
		}
	}
}
