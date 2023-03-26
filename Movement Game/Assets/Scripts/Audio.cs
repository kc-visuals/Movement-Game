using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    bool isPlaying = false;
    public AudioSource audioSource;
    void OnTriggerEnter(Collider other)
    {
        if (isPlaying == false)
        {
            isPlaying = true;
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
    }
}
