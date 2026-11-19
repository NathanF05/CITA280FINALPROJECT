using UnityEngine;
using UnityEngine.EventSystems;

public class NewBasketDropThing : MonoBehaviour, IDropHandler
{
    private int veggieCounter = 0;

    public int vegetableNum1;
    public int vegetableNum2;
    public int vegetableNum3;

    public GameObject blocker1;
    public GameObject blocker2;

    public void OnDrop(PointerEventData eventData) {
        if(eventData.pointerDrag != null) {
            RectTransform dragRect = eventData.pointerDrag.GetComponent<RectTransform>();
            dragRect.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            Destroy(dragRect.gameObject);
            veggieCounter++;

            if (veggieCounter == vegetableNum1)
            {
                Destroy(blocker1);
            }
            else if (veggieCounter == (vegetableNum1 + vegetableNum2))
            {
                Destroy(blocker2);
            }
            else if(veggieCounter == (vegetableNum1 + vegetableNum2 + vegetableNum3))
            {
                print("ALL VEGETABLES COLLECTED!");
            }

            Debug.Log("Item dropped to basket");
        } // check if drag
    } // end OnDrop
}
