using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {
	public GameObject	A;
	public GameObject	S;
	public GameObject	D;

	private	int			i;
	private GameObject	cube_A;
	private GameObject	cube_S;
	private GameObject	cube_D;
	
	// Update is called once per frame
	void Update () {
		i = Random.Range(0, 3);
		if (!cube_A && i == 0)
			cube_A = Instantiate(A);
		if (!cube_S && i == 1)
			cube_S = Instantiate(S);
		if (!cube_D && i == 2)
			cube_D = Instantiate(D);
		if (cube_A && Input.GetKeyDown("a")) {
			Debug.Log("Precision: " + ((cube_A.transform.position.y - 7) / 7 * -100) + "%");
			GameObject.Destroy(cube_A);
		}
		if (cube_S && Input.GetKeyDown("s")) {
			Debug.Log("Precision: " + ((cube_S.transform.position.y - 7) / 7 * -100) + "%");
			GameObject.Destroy(cube_S);
		}
		if (cube_D && Input.GetKeyDown("d")) {
			Debug.Log("Precision: " + ((cube_D.transform.position.y - 7) / 7 * -100) + "%");
			GameObject.Destroy(cube_D);
		}
	}
}
