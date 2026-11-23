using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class NewBasketDropThing : MonoBehaviour, IDropHandler
{
    private int veggieCounter = 0;

    public int vegetableNum1;
    public int vegetableNum2;
    public int vegetableNum3;

    public GameObject blocker1;
    public GameObject blocker2;

    public AudioClip vegetableCollectedSound;

    private MusicManager musicManagerObj;

    public void OnDrop(PointerEventData eventData) {
        if(eventData.pointerDrag != null) {
            RectTransform dragRect = eventData.pointerDrag.GetComponent<RectTransform>();
            dragRect.anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            gameObject.GetComponent<AudioSource>().Play();
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
                if(SceneManager.GetActiveScene().name == "Final (Above Ground)")
                {
                    SceneManager.LoadScene("Final (Below Ground)");
                }
                else if(SceneManager.GetActiveScene().name == "Final (Below Ground)")
                {
                    //Go to cooking scene
                    print("Garden Minigame Done!");
                    musicManagerObj.stopMusic();
                }
            }

            Debug.Log("Item dropped to basket");
        } // check if drag
    } // end OnDrop

    void Awake()
    {
        if (GameObject.FindWithTag("MusicManager") != null){
               musicManagerObj = GameObject.FindWithTag("MusicManager").GetComponent<MusicManager>();
          }
    }
}
