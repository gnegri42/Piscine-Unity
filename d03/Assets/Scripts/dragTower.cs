using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dragTower : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public GameObject		tower;

	private Vector3			initialPosition;
	private Vector3			startPosition;
	private	towerScript		towerScript;
	private Image 	towerSprite;

	//Get tower prefab's script
	void Awake () {
		towerScript = tower.GetComponent<towerScript> ();
		towerSprite = this.GetComponent<Image> ();
	}

	//Change sprite color if not enough energy
	void Update () {
		if (gameManager.gm.playerEnergy < towerScript.energy)
			towerSprite.color = Color.red;
		else
			towerSprite.color = Color.white;
	}

	//Saving position
	public void OnBeginDrag(PointerEventData eventData) {
		initialPosition = transform.position;
	}

	//Draging object
	public void OnDrag(PointerEventData data) {
		if (gameManager.gm.playerEnergy > towerScript.energy) {
			startPosition = Input.mousePosition;
			startPosition.z= 10.0f;
			transform.position = Camera.main.ScreenToWorldPoint(startPosition);
		}
	}

	private void SetDraggedPosition(PointerEventData data) {

	}

	//Instantiate object if targeted zone is empty && we have enough energy
	public void OnEndDrag(PointerEventData eventData) {
		RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint(startPosition), Vector2.zero);
		if ( hit && hit.collider.transform.parent.name == "empty") {
			transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), transform.position.z);
			Instantiate(tower, transform.position, transform.rotation);
			gameManager.gm.playerEnergy -= towerScript.energy;
		}
		transform.position = initialPosition;
	}
}
