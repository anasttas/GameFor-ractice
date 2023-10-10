using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class GameSettings : MonoBehaviour
{
    public float index;
    static public int numberGame; 
    public void ChangeSpeed()
    {
        AIMovement.flexibilityIndex = index;
        Random rnd = new Random();
        //Получить очередное (в данном случае - первое) случайное число
        numberGame = rnd.Next();
        if(numberGame % 2==0)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            SceneManager.LoadScene(5);
        }
    }
}
