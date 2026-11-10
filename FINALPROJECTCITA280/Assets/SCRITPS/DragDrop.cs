using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;


public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler {
  [SerializeField] private Canvas canvas;
  private RectTransform rectTransform;

  private void Awake() {
    rectTransform = GetComponent<RectTransform>();
  } // end Awake
  
  public void OnBeginDrag(PointerEventData eventData) {
    Debug.Log("OnBeginDrag");
  } // end OnBeginDrag

  public void OnDrag(PointerEventData eventData) {
    Debug.Log("OnDrag");
    rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
  } // end OnDrag

  public void OnEndDrag(PointerEventData eventData) {
    Debug.Log("OnEndDrag");
  } // end OnEndDrag
  
  public void OnPointerDown(PointerEventData eventData) {
    Debug.Log("OnPointerDown");
  } // end OnPointerDown

  public void OnDrop(PointerEventData eventData) {
    Debug.Log("OnDrop");
  } // end OnDrop
} // end DragDrop
