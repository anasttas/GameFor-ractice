using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sw : MonoBehaviour
{
    public bool swith = false;
    public Light flash;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            swith = !swith;
            flash.enabled = swith;
        }
    }

}
