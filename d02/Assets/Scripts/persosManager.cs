using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persosManager : MonoBehaviour {
	public List<GameObject>		players = new List<GameObject>();
	//public List<movePlayer>		pScript = new List<movePlayer>();

	private Vector3 			selectPos;
	private Vector3				clickInit;
	// Use this for initialization
	void Start () {
		//Find every Player Tag objects in scene and put them into a list
		foreach (GameObject player in GameObject.FindGameObjectsWithTag("Player"))
			players.Add(player);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire2")) {
			//Drawning a box with click
			selectPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			foreach (GameObject player in GameObject.FindGameObjectsWithTag("Player")) {
				//Initialise everyone to false if no one is selected
				if (!Input.GetKeyDown(KeyCode.LeftControl))
					player.GetComponent<movePlayer>().isSelected = false;
				//Select one player
				if ((player.transform.position.x < selectPos.x + 0.33 && player.transform.position.x > selectPos.x - 0.33)
					&& (player.transform.position.y < selectPos.y + 0.33 && player.transform.position.y > selectPos.y - 0.33))
					player.GetComponent<movePlayer>().isSelected = true;
			}
			Debug.Log("Click pos : " + selectPos);
		}
	}
}
