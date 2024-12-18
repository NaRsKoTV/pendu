using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using Unity.Mathematics;


public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer audioMixer;
    public string volumeName;
  
    void Start()
    {
        // Initialise le slider avec la valeur actuelle du volume
         float volume;
         audioMixer.GetFloat(volumeName, out volume);
        var normalized = math.saturate(math.remap(-80, 20, 0, 1, volume));
        var nonlinear = math.pow(normalized, 1f /0.5f);
        var exponential = math.pow(10f, nonlinear);
        var remapped = math.remap(1, 10, 0, 1, exponential);
        volumeSlider.value = remapped;
    }

    public void SetVolume()
    {
        // Met à jour le volume de l'AudioSource en fonction de la valeur du slider
        audioMixer.SetFloat(volumeName,Mathf.Log(volumeSlider.value)*20 );
    }
}