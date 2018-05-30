using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
	public GameObject	bird;
	public GameObject	pipe;
	public float up;
	public float down;
	public int	score;
	public bool	lose;
	public float		speed;

	// Use this for initialization
	void Start () {
		lose = false;
		speed = 0.08f;
	}
	
	// Update is called once per frame
	void Update () {
		if (bird.transform.position.y >= -3.3 && !lose) {
			bird.transform.Translate(Vector3.down * down);		
			if (Input.GetKeyDown("space"))
				bird.transform.Translate(Vector3.up * up);
		}
		else
		{
			lose = true;
		}
	}

	void	OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "pipe")
			lose = true;
	}

	void	OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "pipe")
			{
				score += 5;
				Debug.Log("Score: " + score);
				speed += 0.015f;
			}
	}
}
