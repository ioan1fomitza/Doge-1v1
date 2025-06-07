using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerOnDestroy : MonoBehaviour
{
    public GameObject Messi;
    public GameObject Ronaldo;

    public string sceneToLoadForfinishM;
    public string sceneToLoadForfinishR;

    void Update()
    {
        if (Messi == null)
        {
            SceneManager.LoadScene(2);
        }

        if (Ronaldo == null)
        {
            SceneManager.LoadScene(3);
        }
    }
}


