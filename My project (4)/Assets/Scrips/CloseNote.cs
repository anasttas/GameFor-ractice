using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseNote : MonoBehaviour
{
    public void DestroyImage()
    {
        Debug.Log("!");
        this.transform.parent.gameObject.SetActive(false);       
        Cursor.lockState = CursorLockMode.Locked;
    }
}
