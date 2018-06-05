using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class successMenu : MonoBehaviour {
	public GameObject 	menuVictory;
	public Text			successText;
	public Text			scoreText;
	public Text			buttonText;
	public Button		successButton;

	// Use this for initialization
	void Start () {
		successButton.onClick.AddListener(GameOverButton);
	}
	
	// Update is called once per frame
	void Update () {
		if (gameManager.gm.playerHp <= 0) {
			menuVictory.SetActive(true);
			successText.text = "Game Over!";
			scoreText.text = "Your Score : " + gameManager.gm.score.ToString();
			buttonText.text = "Rejouer";
		}
		if (checkLastEnemy()) {
			menuVictory.SetActive(true);
			successText.text = "Success!";
			scoreText.text = "Your Score : " + gameManager.gm.score.ToString();
			buttonText.text = "Niveau Suivant!";
		}
	}

	void GameOverButton () {
		if (gameManager.gm.playerHp <= 0)
			SceneManager.LoadScene("ex03");
		else
			SceneManager.LoadScene("ex04");			
	}

	public bool checkLastEnemy() {
		if (gameManager.gm.lastWave == true) {
			GameObject[] spawners = GameObject.FindGameObjectsWithTag("spawner");
			foreach (GameObject spawner in spawners) {
				if (spawner.GetComponent<ennemySpawner>().isEmpty == false || spawner.transform.childCount > 1) {
					return (false);
				}
			}
			return (true);
		}
		return (false);
	}
}
