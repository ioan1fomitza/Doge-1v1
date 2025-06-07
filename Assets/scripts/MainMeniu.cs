using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMeniu : MonoBehaviour
{
    public void PLayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

}


