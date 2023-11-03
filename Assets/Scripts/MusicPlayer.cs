using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour
{
    public AudioClip firstClip;
    public AudioClip secondClip;
    AudioSource audioSource;
    public bool isPlaying = true;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlaySound());
    }

    IEnumerator PlaySound()
    {
        audioSource.PlayOneShot(firstClip);
        yield return new WaitForSeconds(firstClip.length);
        audioSource.PlayOneShot(secondClip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
