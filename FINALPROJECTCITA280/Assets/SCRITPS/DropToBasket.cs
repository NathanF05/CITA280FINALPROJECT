using UnityEngine;
using UnityEngine.EventSystems;


public class DropToBasket : MonoBehaviour, IDropHandler {
  public void OnDrop(PointerEventData eventData) {
    if(eventData.pointerDrag != null) {
      RectTransform dragRect = eventData.pointerDrag.GetComponent<RectTransform>();
      dragRect.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

      Debug.Log("Item dropped to basket");
    } // check if drag
  } // end OnDrop

} // end DropToBasket
