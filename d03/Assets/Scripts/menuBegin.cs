using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuBegin : MonoBehaviour {
	public Button	playBtn;
	public Button	exitBtn;
	
	// Use this for initialization
	void Start () {
        //Calls the TaskOnClick method when you click the Button
        playBtn.onClick.AddListener(PlayGame);
        exitBtn.onClick.AddListener(ExitGame);
	}
	
	//Get scene 01
	void PlayGame() {
		SceneManager.LoadScene("ex01");
	}

	void ExitGame() {
		Application.Quit();
	}
}
