using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPause : MonoBehaviour {
	public GameObject 	menuObj;

	private bool 		isActive = false;

	// Update is called once per frame
	void Update () {
		//Set pause to true if active
		if (isActive == true) {
			gameManager.gm.pause(true);
			menuObj.SetActive(true);
		}
		else {
			gameManager.gm.pause(false);
			menuObj.SetActive(false);
		}

		if (Input.GetKeyDown(KeyCode.Escape)) {
			Resume();
		}
	}

	void Resume () {
		isActive =! isActive;
	}
}
