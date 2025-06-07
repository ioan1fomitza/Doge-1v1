using UnityEngine;
using UnityEngine.SceneManagement;

public class Potiune2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<MiscareaMR>() != null)
        {
            other.gameObject.GetComponent<MiscareaMR>()._speed = 3f;
        }

        Destroy(gameObject); // destroys this object when it enters a trigger

    }

}
