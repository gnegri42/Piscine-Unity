using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dataSelect : MonoBehaviour {
	public int 	selectedLevel = 0;
	public List<GameObject> levelList;
	public int 	totalLevels = 4;
	public Text levelName;
	public Text lifesNumber;
	public Text ringsNumber;
	public Text levelScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			if (selectedLevel < totalLevels - 1)
				selectedLevel++;
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			if (selectedLevel > 0)
				selectedLevel--;
		}
		transform.position = levelList[selectedLevel].transform.position;
		levelName.text = levelList[selectedLevel].name;
		SetTextLifesNumber();
		SetTextRingsNumber();
		SetTextLevelScore();
	}

	void SetTextLifesNumber () {
		lifesNumber.text = PlayerPrefs.GetInt("lostLives").ToString();
	}
	void SetTextRingsNumber () {
		ringsNumber.text = PlayerPrefs.GetInt("rings").ToString();
	}
	void SetTextLevelScore () {
		levelScore.text = PlayerPrefs.GetInt("lvl" + selectedLevel + "Score").ToString();
	}
}
