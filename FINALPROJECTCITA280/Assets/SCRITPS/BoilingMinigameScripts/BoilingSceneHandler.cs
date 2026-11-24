using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class BoilingSceneHandler : MonoBehaviour
{
    // create serialized fields
    public Slider cookedSlider;

    public GameObject burnerDialObject;
    private int heat;

    public Image steamArt;

    public TextMeshProUGUI winText;


    // create variables to be assigned at start
    private float cookedSliderMax;


    // erythang else
    bool gameStarted = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created //
    void Start()
    {
        cookedSliderMax = cookedSlider.maxValue;

        winText.gameObject.SetActive(false);

        steamArt.color = new Color (1, 1, 1, 0);
    }

    // Update is called once per frame //
    void Update()
    {
        heat = burnerDialObject.GetComponent<DialController>().heatValue;

        if ( gameStarted )
        {
            steamArt.color = new Color(1, 1, 1, (float) heat / 3);

            if (heat != 0)
            {
                cookedSlider.value = cookedSlider.value + Mathf.Pow(2, heat);

                if (cookedSlider.value >= cookedSliderMax)
                {
                    gameEnd();
                }

            }
            if (heat == 0)
            {
                gameEnd();
            }
        } 
        if ( !gameStarted )
        {
            if (heat != 0)
            {
                gameStarted = true;
            }
        }

    }

    // minigame end function
    void gameEnd()
    {
        // prevent further interaction
        gameStarted = false;
        burnerDialObject.GetComponent<DialController>().canTurn = false;


        // are they winnin son?
        float score = cookedSlider.value;

        if (score <= cookedSliderMax * 3/4)
        {
            winText.text = "Undercooked :(";
        }
        if (score >= cookedSliderMax * 3 / 4)
        {
            winText.text = "Done! :)";
        }
        if (score >= cookedSliderMax)
        {
            winText.text = "Overcooked :(";
        }

        winText.gameObject.SetActive(true); 
    }


    // one more time!
    public void gameRestart()
    {
        burnerDialObject.GetComponent<DialController>().canTurn = true;
        burnerDialObject.GetComponent<DialController>().snapTo = 0;
        burnerDialObject.GetComponent<DialController>().heatValue = 0;

        cookedSlider.value = 0;
        winText.gameObject.SetActive(false);
    }

}
