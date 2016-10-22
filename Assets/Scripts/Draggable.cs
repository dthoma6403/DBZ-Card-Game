using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public void OnBeginDrag(PointerEventData eventData){
		Debug.Log ("Beginning to Drag");
	}

	public void OnDrag(PointerEventData eventData){
		Debug.Log ("DRAGGING");

		this.transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData){
		Debug.Log ("Stopped Dragging");
	}
}
