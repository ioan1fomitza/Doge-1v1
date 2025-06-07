using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by: " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Stopped triggering: " + other.name);
    }
}
