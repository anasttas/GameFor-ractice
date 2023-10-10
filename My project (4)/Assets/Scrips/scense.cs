using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scense : MonoBehaviour
{
    static public AudioSource aud;

    public void Start()
    {
        //aud=GameObject.FindWithTag("MainSound").GetComponent<AudioSource>();
    }
    public void LoadScen(int sceneid)
    {
        SceneManager.LoadScene(sceneid);
    }
}
