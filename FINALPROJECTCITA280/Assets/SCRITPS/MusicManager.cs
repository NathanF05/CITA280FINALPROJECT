using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void stopMusic()
    {
        gameObject.GetComponent<AudioSource>().Stop();
        Destroy(gameObject);
    }
    
}

