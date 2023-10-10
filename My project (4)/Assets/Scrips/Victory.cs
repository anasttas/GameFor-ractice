using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public TMP_Text text;

    public void OnTriggerEnter(Collider other)
    {
        if (FirstPersonMovement.notes == 8 && other.gameObject.tag == "Person")
        {
            //AfterScreamer.textLoseOrVin.text = "победа";
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(3);
        }
    }
}
