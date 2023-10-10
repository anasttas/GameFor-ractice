using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private bool isOpen;
    private Animator anim;

    public void Open()
    {
        anim.SetBool("openDoor", isOpen);
        isOpen = !isOpen;
    }

    public void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Person")
        {
            Open();
        }
    }

}
