using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PopDiscuss : MonoBehaviour
{
    public GameObject nameBox;
    public GameObject speechBox;
    public TextMeshProUGUI name_Text;
    public TextMeshProUGUI speech_Text;

    public crop_check = 0;
    
    void Start()
    {
        spk_Name = "Person 1"
        spk_text = "This is something."
        crop_check = 0;
        spkTrack();
        nameTrack();
        cropTrack();
        nameBox.SetActive(true);
        speechBox.SetActive(true);
    }

    void spkTrack()
    {
        speech_Text.text = "" + spk_text;
    }

    void nameTrack()
    {
        name_Text.text = "" + spk_Name;
    }

    void FixedUpdate()
    {
        #
    }

    void cropTrack()
    {
        if(crop_check == 1)
        {
            #okra
        }
        else if(crop_check == 2)
        {
            #tomato
        }
        else if(crop_check == 3)
        {
            #corn
        }
        else if(crop_check == 4)
        {
            #carrot
        }
        else if(crop_check == 5)
        {
            #onion
        }
        else if(crop_check == 6)
        {
            #celery
        }
        else
        {
            #Nothing
        }
    }
}
