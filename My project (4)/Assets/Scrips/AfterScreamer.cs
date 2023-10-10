using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AfterScreamer : MonoBehaviour
{
    public TMP_Text text;
    public static string timer;
    static public TMP_Text textLoseOrVin;

    // Start is called before the first frame update
    void Start()
    {
        textLoseOrVin = GameObject.Find("loseOrVin").GetComponent<TMP_Text>();
        text.text = Timer.timer;
    }
}
