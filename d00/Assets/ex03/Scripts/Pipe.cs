using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	public GameObject	bird;
	public GameObject	pipe;
	public float		begin;
	public float		end;

	private Bird	bird_script;
	private int		score;
	private Vector3	temp;
	// Use this for initialization
	void Start () {
		pipe = gameObject;
		bird_script = bird.GetComponent<Bird>();
		score = bird_script.score;
		temp = pipe.transform.position;
		temp.x = begin;
	}
	
	// Update is called once per frame
	void Update () {
		if (!bird_script.lose) {
			pipe.transform.Translate(Vector3.left * bird_script.speed);
			if (pipe.transform.position.x <= end)
				pipe.transform.position = temp;
		}
	}
}
