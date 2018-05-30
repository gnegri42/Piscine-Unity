using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitSuccess : MonoBehaviour {
	public exitDoors a;
	public exitDoors b;
	public exitDoors c;
	
	// Update is called once per frame
	void Update () {
		//Check if all exits are occupied
		if (a.exit && b.exit && c.exit)
		{
			Debug.Log("Success");
			SceneManager.LoadScene("ex02");
		}
	}
}
