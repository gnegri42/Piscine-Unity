using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class movePlayer : MonoBehaviour {

	public float			movingSpeed = 0.05f;
	public bool 			isSelected;
	public bool				isPlayable = false;

	private SpriteRenderer 	sr;
	private Animator		anim;
	private AudioSource		audio;
	private Vector3			normalisedDir;
	private	Vector3			remainingDist;
	private bool			isAttacking;

	//Getting components
	void Awake () {
		sr = GetComponent<SpriteRenderer> ();
		anim = GetComponent<Animator> ();
		audio = GetComponent<AudioSource>();	
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Getting click position to move player
		if (Input.GetMouseButtonDown(0) && isSelected)
		{
			GetDistance();
			ResetAnim();
			if (!audio.isPlaying)
				audio.Play();
		}
		if ((remainingDist.x > 0.05f || remainingDist.x < -0.05f)
			|| (remainingDist.y > 0.05f || remainingDist.y < -0.05f)) {
			Move();
			AnimateCharacter();
		}
		else 
			ResetAnim();
		//Debug.Log("Selected : " + isSelected);
	}

	//Getting distance beetween click and position
	void GetDistance () {
		normalisedDir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		normalisedDir -= transform.position;
		normalisedDir.z = 0;
		remainingDist = normalisedDir;
		normalisedDir = normalisedDir.normalized;
		//gameObject.transform.position = normalisedDir;

	}

	//Moving charachter
	void Move () {
		remainingDist -= normalisedDir * movingSpeed;
		gameObject.transform.Translate(normalisedDir * movingSpeed);
	}

	//Link character animations with direction
	void AnimateCharacter () {
		if (remainingDist.x > 0.05f)
			anim.SetBool("walkingRight", true);
		else if (remainingDist.x < -0.05f) {
			anim.SetBool("walkingRight", true);
			sr.flipX = true;
		}
		if (remainingDist.y > 0.05f) {
			anim.SetBool("walkingUp", true);
		}
		else if (remainingDist.y < -0.05f) {
			anim.SetBool("walkingDown", true);
		}
	}

	//Reset Animations to static
	void ResetAnim () {
		foreach (AnimatorControllerParameter parameter in anim.parameters)
			anim.SetBool(parameter.name, false);
		sr.flipX = false;
	}

	//Attack cities
	void OnTriggerEnter(Collider other) {
         if(other.gameObject.tag == "City") {
            isAttacking = true;
			InvokeRepeating("LoseLife(other.gameObject)", 0.0f, 2.0f);
         }
		 else
		 	isAttacking = false;
 	}
	
	void LoseLife(GameObject city) {
		city.GetComponent<City>().life -= 4;
	}
}
