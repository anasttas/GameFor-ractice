using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Music;

public class MusicValue : MonoBehaviour
{
    public AudioSource src;

    public void Update()
    {
        src.volume = volume;
    }

    public void SetVolume()
    {
        volume = GetComponent<UnityEngine.UI.Slider>().value;
        src.volume = volume;
    }
}
