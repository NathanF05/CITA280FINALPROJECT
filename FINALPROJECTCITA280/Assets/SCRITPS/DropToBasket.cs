using UnityEngine;
using UnityEngine.EventSystems;


public class DropToBasket : MonoBehaviour, IDropHandler {
  public void OnDrop(PointerEventData eventData) {
    if(eventData.pointerDrag != null) {
      // vegetable visible in basket when dropped
      //RectTransform dragRect = eventData.pointerDrag.GetComponent<RectTransform>();
      //dragRect.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

      // vegetable disappears when dropped to basket
      Destroy(eventData.pointerDrag);
      Debug.Log("Item dropped to basket");
    } // check if drag
  } // end OnDrop

} // end DropToBasket
