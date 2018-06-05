using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuPause : MonoBehaviour {
	public GameObject 	menuObj;
	public GameObject 	menuObjPause;
	public GameObject 	menuObjConfirm;
	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Button			resumeButton;
	public Button			quitButton;
	public Button			resumeConfirmButton;
	public Button			quitConfirmButton;

	private bool 		isActive = false;

	void Awake() {
		Cursor.SetCursor(cursorTexture, Vector2.zero, cursorMode);
	}

	void Start () {
        //Calls the TaskOnClick method when you click the Button
        resumeButton.onClick.AddListener(Resume);
        quitButton.onClick.AddListener(SwitchToConfirm);
        resumeConfirmButton.onClick.AddListener(Resume);
        quitConfirmButton.onClick.AddListener(QuitConfirm);
	}
	// Update is called once per frame
	void Update () {
		//Set pause to true if active
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Resume();
		}
	}

	//Set game in pause or not
	void Resume () {
		if (isActive == true) {
			isActive= false;
			gameManager.gm.pause(false);
			SwitchToPause();
			menuObj.SetActive(false);
		}
		else {
			isActive = true;
			gameManager.gm.pause(true);
			menuObj.SetActive(true);
			SwitchToPause();
		}
	}

	//See confirmation menu before quitting
	void SwitchToConfirm () {
		menuObjPause.SetActive(false);
		menuObjConfirm.SetActive(true);
	}

	//Go back to pause menu
	void SwitchToPause () {
		menuObjPause.SetActive(true);
		menuObjConfirm.SetActive(false);
	}
	//Go back to main menu
	void QuitConfirm () {
		SceneManager.LoadScene("ex00");
	}
}
