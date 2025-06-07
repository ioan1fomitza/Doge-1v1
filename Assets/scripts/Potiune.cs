using UnityEngine;
using UnityEngine.SceneManagement;

public class Potiune : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<MiscareaMR>()!=null)
        {
            other.gameObject.GetComponent<MiscareaMR>()._speed = 15f;
        }

        Destroy(gameObject); // destroys this object when it enters a trigger

    }
         
}
