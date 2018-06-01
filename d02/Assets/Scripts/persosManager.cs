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
		if (Input.GetMouseButtonDown(1)) {
			//Drawning a box with click : https://docs.unity3d.com/ScriptReference/Rect-ctor.html
			selectPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				//Initialise everyone to false if no one is selected
			foreach (GameObject player in GameObject.FindGameObjectsWithTag("Player")) {
				if (!Input.GetKey(KeyCode.LeftControl))
					player.GetComponent<movePlayer>().isSelected = false;
			}
				//Select one player
			foreach (GameObject player in GameObject.FindGameObjectsWithTag("Player")) {
				if ((player.transform.position.x < selectPos.x + 0.33 && player.transform.position.x > selectPos.x - 0.33)
					&& (player.transform.position.y < selectPos.y + 0.33 && player.transform.position.y > selectPos.y - 0.33)
					&& player.GetComponent<movePlayer>().isPlayable == true) {
					player.GetComponent<movePlayer>().isSelected = true;
					if (!Input.GetKey(KeyCode.LeftControl))
						break;
				}
			}
		}
	}
}
