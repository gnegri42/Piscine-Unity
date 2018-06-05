using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class towerText : MonoBehaviour {
	public GameObject	tower;
	public Text			spawnTimeText;
	public Text			dmgText;
	public Text			rngeText;
	public Text			towerEnergyText;
	
	// Update is called once per frame
	void Start () {
		spawnTimeText.text = tower.GetComponent<towerScript>().fireRate.ToString();		
		dmgText.text = tower.GetComponent<towerScript>().damage.ToString();		
		rngeText.text = tower.GetComponent<towerScript>().range.ToString();		
		towerEnergyText.text = tower.GetComponent<towerScript>().energy.ToString();		
	}
}
