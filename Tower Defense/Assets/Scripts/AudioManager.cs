using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    // Start is called before the first frame update
    void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        Play("Theme");
    }

    public void Play(string name)
    {
        Sound foundSound = Array.Find(sounds, Sound => Sound.name == name);

        if (foundSound == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        foundSound.source.Play();
    }

    public void Stop(string name)
    {
        Sound foundSound = Array.Find(sounds, Sound => Sound.name == name);

        if (foundSound == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        foundSound.source.Stop();
    }

    public void ClickButton()
    {
        Play("Button Click");
    }
}
