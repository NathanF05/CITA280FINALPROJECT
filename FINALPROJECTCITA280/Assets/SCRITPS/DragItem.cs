using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class DragItem : MonoBehaviour {
  [SerializeField] private bool isDragging = false; 

  void Update() {
    if(isDragging) {
      transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    } // end isDragging
  } // end Update

  private void OnMouseDown() {
    isDragging = !isDragging;
  } // end OnMouseDown

} // end DragItem
