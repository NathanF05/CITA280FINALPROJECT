using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System;
using Unity.VisualScripting;


public class NewDragDrop : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {
    private RectTransform rectTransform;
    private Image image;
    private bool hasChild = true;

    [SerializeField] 
    private GameObject dirtLayer;
        
    public void OnBeginDrag(PointerEventData eventData) {
        // make transparent 
        image.color = new Color32(255, 255, 255, 170);
            if (hasChild == true)
            {
                Destroy(dirtLayer);
                hasChild = false;      
            }
        
    } // end OnBeginDrag

    public void OnDrag(PointerEventData eventData) {
        rectTransform.anchoredPosition += eventData.delta;

        // transform.position = Input.mousePosition;
    } // end OnDrag

    public void OnEndDrag(PointerEventData eventData) {
        // default color
        image.color = new Color(255, 255, 255, 255);
    } // end OnEndDrag

    void Start() {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    } // end Start

} // end DragDrop
