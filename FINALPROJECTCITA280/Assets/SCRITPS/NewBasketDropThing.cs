using UnityEngine;
using UnityEngine.EventSystems;

public class NewBasketDropThing : MonoBehaviour, IDropHandler
{
    private int veggieCounter = 0;
    public GameObject blocker1;
    public GameObject blocker2;

    public void OnDrop(PointerEventData eventData) {
        if(eventData.pointerDrag != null) {
            RectTransform dragRect = eventData.pointerDrag.GetComponent<RectTransform>();
            dragRect.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            Destroy(dragRect.gameObject);
            veggieCounter++;

            if (veggieCounter == 2)
            {
                Destroy(blocker1);
            }
            else if (veggieCounter == 4)
            {
                Destroy(blocker2);
            }
            else if(veggieCounter>= 6)
            {
                print("ALL VEGETABLES COLLECTED!");
            }

            Debug.Log("Item dropped to basket");
        } // check if drag
    } // end OnDrop
}
