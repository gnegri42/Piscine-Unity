using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getText : MonoBehaviour {
	public Text 	hpText;
	public Text		energieText;
	
	// Update is called once per frame
	void Update () {
		hpText.text = gameManager.gm.playerHp.ToString();		
		energieText.text = gameManager.gm.playerEnergy.ToString();
	}
}
