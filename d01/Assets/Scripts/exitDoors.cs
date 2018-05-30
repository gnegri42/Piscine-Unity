using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitDoors : MonoBehaviour {
	public	bool	exit = false;
	
	// // Update is called once per frame
	// void Update () {
		
	// }

	//Check if object is on exit
	void OnTriggerStay2D(Collider2D col)
	{
		exit = true;
	}
}
