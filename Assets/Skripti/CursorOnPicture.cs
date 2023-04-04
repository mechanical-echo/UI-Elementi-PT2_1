using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorOnPicture : MonoBehaviour {
    public GameObject Bean;
    public AudioSource BeanAudioSource;
    public AudioClip BeanAudioClip;

    public void Above()
    {
        BeanAudioSource.PlayOneShot(BeanAudioClip);
    }
    public void NotAbove()
    {
        BeanAudioSource.Stop();
    }
}
