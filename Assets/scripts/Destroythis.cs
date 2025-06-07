using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroythis : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject); // destroys object when it enters a trigger

    }

}

