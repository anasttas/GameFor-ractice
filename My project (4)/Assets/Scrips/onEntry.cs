using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onEntry : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private bool sw = false;

    public void OnMouseEnter()
    {
        anim.SetBool("active", true);
    }
    
    public void OnMouseExit()
    {
        anim.SetBool("active", false);
    }
}
