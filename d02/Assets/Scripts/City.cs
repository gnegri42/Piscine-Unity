using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour {
	public int 			life = 10;
	public GameObject	citizen;
	public bool			townHall;
	public Vector3		spawnPosition = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
		if (townHall)
			InvokeRepeating("SpawnCitizen", 2.0f, 10.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnCitizen() {
		Instantiate(citizen, spawnPosition, Quaternion.identity);
	}
}
