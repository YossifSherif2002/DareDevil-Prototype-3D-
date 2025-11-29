using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    [SerializeField] private AudioMixer master_mixer;
    [SerializeField] private SaveAndLoad SaveAndLoadManager;

    public Slider volume_slider;


    private void Start()
    {
        SaveAndLoadManager.Load();
    }

    private void Update()
    {
        master_mixer.SetFloat("MasterVolume", volume_slider.value);
    }
}
