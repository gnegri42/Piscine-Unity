using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour {
	public int 			life = 10;
	public GameObject	citizen;
	public bool			townHall;
	public Vector3		spawnPosition = new Vector3(0, 0, 0);

	private float		spawnTime = 10.0f;
	// Use this for initialization
	void Start () {
		if (townHall)
			InvokeRepeating("SpawnCitizen", 2.0f, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		//If no life, destroy
		if (life <= 0)
			Destroy(this.gameObject);
	}

	//Spawn character every 10 seconds
	void SpawnCitizen() {
		Instantiate(citizen, spawnPosition, Quaternion.identity);
	}

	 // Get life off when clicked
	void OnMouseDown(){
		life -= 3;
	}
}
