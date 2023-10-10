using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Repeat : MonoBehaviour
{
    public void LoadScen()
    {
        if (GameSettings.numberGame % 2 == 0)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(5);
        }
    }
}
