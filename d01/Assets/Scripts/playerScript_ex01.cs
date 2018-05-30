using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerScript_ex01 : MonoBehaviour {
	public playerScript_ex01 p1;
	public playerScript_ex01 p2;
	public playerScript_ex01 p3;
	public float		speed;
	public float		jumpHeight;

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
			SceneManager.LoadScene("ex01");

		//Move player
		if (Input.GetKey("left"))
			transform.Translate(Vector3.left * speed);
		if (Input.GetKey("right"))
			transform.Translate(Vector3.right * speed);
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
			this.enabled = false;
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
