using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class PopDiscuss : MonoBehaviour
{
    public GameObject show_box;
    public TextMeshProUGUI say_box;
    public TextMeshProUGUI name_box;
    public string nameHere;
    public string sayHere;

    private bool closeNow;
    private int ID_text; //Its fine, just keep tabs at it.


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        show_box.SetActive(false);
        sayControl();
    }

    public void sayControl()
    {
        show_box.SetActive(true);
        sayText();
        name_box.text = "" + nameHere;
        say_box.text = "" + sayHere;
        // Wait for around 3 seconds
        closeBox();
        if(closeNow == true)
        {
            show_box.SetActive(false);
        }
        else
        {
            show_box.SetActive(true);
        }
    }

    // Change this function base on dialog system!
    public void sayText()
    {
        nameHere = "Here is name";
        sayHere = "Here is where you say";
    }

    // More needs to be added in the future
    private void closeBox()
    {
        closeNow = true;
    }

    void Update()
    {
        /*The following was added with the assistance of AI.
        This section is a placeholder section.
        I intend to change it once a proper system is applied.
        */

        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Convert mouse screen position to 2D world position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Check if a Collider2D exists at that point
            Collider2D hitCollider = Physics2D.OverlapPoint(mousePos);

            if (hitCollider != null)
            {
                // Safely check the tag using CompareTag
                if (hitCollider.CompareTag("Carrot"))
                {
                    //Carrot text ID Section
                    ID_text = 0;
                }
                else if (hitCollider.CompareTag("Celery"))
                {
                    //Celery text ID Section
                    ID_text = 1;
                }
                else if (hitCollider.CompareTag("Corn"))
                {
                    //Corn text ID Section
                    ID_text = 2;
                }
                else if (hitCollider.CompareTag("Okra"))
                {
                    //Okra text ID Section
                    ID_text = 3;
                }
                else if (hitCollider.CompareTag("Tomato"))
                {
                    //Tomato text ID Section
                    ID_text = 4;
                }
                else if (hitCollider.CompareTag("Onion"))
                {
                    //Onion text ID Section
                    ID_text = 5;
                }
            }
        }
    }

    // private void OnCollisionEnter2D(Collider2D collison)
    // {
    //     string objectName = collision.GameObject.name;
    //     int idCall;

    //     // Example: Check for a specific object name
    //     if (collision.gameObject.name == "Unripe")
    //     {
    //         //Apply system to fetch ID and add to sayText() function
    //         idCall = ID_text + 1;
    //     }
    //     else if (collision.gameObject.name == "bugged")
    //     {
    //         //Apply system to fetch ID and add to sayText() function
    //         idCall = ID_text + 2;
    //     }
    //     else
    //     {
    //         //Apply system to fetch ID and add to sayText() function
    //         idCall = ID_text + 3;
    //     }
    // }
}
