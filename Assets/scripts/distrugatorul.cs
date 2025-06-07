using UnityEngine;
using UnityEngine.SceneManagement;

public class distrugatorul : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject); // destroys this object when it enters a trigger
        
    }
    
}
