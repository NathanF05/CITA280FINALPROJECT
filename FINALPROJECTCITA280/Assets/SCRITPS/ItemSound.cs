using UnityEngine;

public class ItemSound : MonoBehaviour
{

    public AudioClip pickUpSound; // Use the inspector to drag a sound onto this field

    void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(pickUpSound, transform.position);
        Destroy(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
