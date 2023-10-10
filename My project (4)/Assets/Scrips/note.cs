using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class note : MonoBehaviour
{
    private bool isTouching = false;
    public AudioSource a;
    public TMP_Text textNotes;
    public GameObject notesImage;
    public GameObject cross;
    public Transform canvas;
    static public GameObject gmNot;
    

    private void Start()
    {
        textNotes=GameObject.Find("textNote").GetComponent<TMP_Text>();
        canvas = GameObject.Find("Canvas").GetComponent<Transform>();
        a = GameObject.FindWithTag("noteAudioSource").GetComponent<AudioSource>();
        //notesImage = GameObject.Find("Notes");
        FirstPersonMovement.notes = 0;
    }

    public void Sound() => a.Play();

    private void Update()
    {
        if(isTouching)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                FirstPersonMovement.notes++;
                textNotes.text = FirstPersonMovement.notes.ToString() + "/8";
                Sound();
                Destroy(this.gameObject);
                //gmNot = Instantiate(notesImage, canvas);
                //cross.SetActive(true);
                //Time.timeScale = 0;
                //Cursor.lockState = CursorLockMode.None;
            }
        }
        
    }

    void OnTriggerEnter(Collider col)
    {
        isTouching = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isTouching = false;
    }

}
