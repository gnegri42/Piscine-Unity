using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userPrefs : MonoBehaviour {
	public InputField		input;
	public int				lifes;
	public int				rings;
	public int				score;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetString("user") != null)
			input.text = PlayerPrefs.GetString("user");
	// Ce profil doit contenir la liste des niveaux
	// débloqués par le joueur, le nombre de vies qu’il a perdu toutes parties confondues,
	// le nombre d’anneaux gagnés toutes parties confondues ainsi que son meilleur score de run
	// sur chaque niveau.
	}
	
	public void Update() {
		PlayerPrefs.SetString("user", input.text);
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
