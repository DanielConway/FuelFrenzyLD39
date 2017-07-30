using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {
    public AudioSource turboFuel, doubleScore, strength, fuel, death;

    public AudioSource music;
    public Slider musicSlider;

    private void Update()
    {
        music.volume = musicSlider.value;
    }

    
}
