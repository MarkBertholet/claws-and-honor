using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour {

    public AudioMixer audioMixer;

	public void SetMaster (float master)
    {
        audioMixer.SetFloat("master", master);
    }
}
