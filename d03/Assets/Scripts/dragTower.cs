using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dragTower : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public GameObject	tower;

	private Vector3		initialPosition;
	private Vector3		startPosition;
	public void OnBeginDrag(PointerEventData eventData) {
		initialPosition = transform.position;
	}

	public void OnDrag(PointerEventData data) {
		startPosition = Input.mousePosition;
		startPosition.z= 10.0f;
		transform.position = Camera.main.ScreenToWorldPoint(startPosition);
	}

	private void SetDraggedPosition(PointerEventData data) {

	}

	public void OnEndDrag(PointerEventData eventData) {
		RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint(startPosition), Vector2.zero);
		if ( hit && hit.collider.transform.parent.name == "empty") {
			transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), transform.position.z);
			Instantiate(tower, transform.position, transform.rotation);
		}
		transform.position = initialPosition;
	}
}
