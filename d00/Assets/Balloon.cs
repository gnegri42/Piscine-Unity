using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {
	public GameObject	balloon;
	public int			souffle;
	private int			souffle_max;

	// Use this for initialization
	void Start () {
		souffle = 0;
		souffle_max = 18;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && souffle != souffle_max)
		{
        	balloon.transform.localScale += new Vector3 (0.07f, 0.07f, 0.07f);
			souffle += 1;
		}
		else if (balloon.transform.localScale.x > 0.01 && balloon.transform.localScale.y > 0.01)
			balloon.transform.localScale -= new Vector3 (0.004f, 0.004f, 0.004f);
		if ((balloon.transform.localScale.x > 0.7 && balloon.transform.localScale.y > 0.7) || (balloon.transform.localScale.x <= 0.01 && balloon.transform.localScale.y <= 0.01))
		{
			Destroy(balloon);
			Debug.Log(Mathf.RoundToInt(Time.time));
		}
	}
}
