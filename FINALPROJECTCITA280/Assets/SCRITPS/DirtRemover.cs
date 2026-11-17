using UnityEngine;

public class DirtRemover : MonoBehaviour
{
    void OnCollisionEnter(Collision coll) {
        if (coll.gameObject.tag == "dirt") {
            Destroy (coll.gameObject);
        }
    }
}
