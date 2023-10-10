using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public System.TimeSpan time;
    public int second;
    public int minute;
    public TMP_Text timerText;
    [SerializeField] public int delta = 0;
    public static string timer;

    void Start()
    {
        timerText = GameObject.Find("timerText").GetComponent<TMP_Text>();
        StartCoroutine(ITimer());
    }
    IEnumerator ITimer()
    {
        while (true)
        {
            if (second == 59)
            {
                minute++;
                second = -1;
            }
            second += delta;
            timerText.text = minute.ToString("D2") + " : " + second.ToString("D2");
            timer = minute.ToString("D2") + " : " + second.ToString("D2");
            yield return new WaitForSeconds(1);
        }
    }
}
