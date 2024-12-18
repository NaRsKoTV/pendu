using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{  
    public static AudioManager Instance { get; private set;}    
    [SerializeField]
    private AudioSource[] audioSources;

    [SerializeField]
    private AudioClip boutonSfx;
    private void Awake(){
        Instance = this;
    }
    public void PlayButtonSfx()
    {
        audioSources[1].PlayOneShot(boutonSfx);
    }
}
