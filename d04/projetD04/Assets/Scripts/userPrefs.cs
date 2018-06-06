using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class userPrefs : MonoBehaviour {
	public InputField		input;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetString("user") != null)
			input.text = PlayerPrefs.GetString("user");
	}
	
	public void Update() {
		if (Input.GetKeyDown(KeyCode.Return))
			SceneManager.LoadScene("DataSelect", LoadSceneMode.Additive);
		PlayerPrefs.SetString("user", input.text);
		PlayerPrefs.SetInt("lostLives", 0);
		PlayerPrefs.SetInt("rings", 0);
		PlayerPrefs.SetInt("maxLevel", 0);
		PlayerPrefs.SetInt("lvl0Score", 0);
		PlayerPrefs.SetInt("lvl1Score", 0);
		PlayerPrefs.SetInt("lvl2Score", 0);
		PlayerPrefs.SetInt("lvl3Score", 0);
	}

	//Save prefs
	public void Save() {
		PlayerPrefs.Save();
	}

	//Delete prefs
	public void DeletePrefs() {
		PlayerPrefs.DeleteAll();
	}
}
