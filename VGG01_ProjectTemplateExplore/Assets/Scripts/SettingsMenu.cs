using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// since this is using audio, we will need to call up the unity engine's audio class
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    // public variable asking for the audio mixer
    public AudioMixer audioMixer;

    // a method called on where to set the volume based on a float which will be set with a slider
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
