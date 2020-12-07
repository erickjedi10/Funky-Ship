using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    public static SoundSystem sonidito;
    public AudioClip coin;
    public AudioClip bird;
    public AudioClip hit;
    public AudioSource Audio;

    private void Awake()
    {
        if (SoundSystem.sonidito == null)
        {
            SoundSystem.sonidito = this;

        }
        else if (SoundSystem.sonidito != this) 
        {
            Destroy(gameObject);
        }

    }
    public void PlayCoin() 
    {
        Audio.clip = coin;
        Audio.Play();
    
    }
    public void PlayFlap()
    {
        Audio.clip = bird;
        Audio.Play();

    }

    public void PlayImpact()
    {
        Audio.clip = hit;
        Audio.Play();

    }
    // Start is called before the first frame update

    private void OnDestroy()
    {
        if (SoundSystem.sonidito == this) 
        {
            SoundSystem.sonidito = null;
        }
    }
}
