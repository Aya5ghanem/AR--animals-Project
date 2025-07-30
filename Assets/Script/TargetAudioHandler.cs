using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TargetAudioHandler : MonoBehaviour
{
    public static TargetAudioHandler currentVisibleTarget;

    private ObserverBehaviour observer;
    private AudioSource audioSource;

    private void Awake()
    {
        observer = GetComponent<ObserverBehaviour>();
        audioSource = GetComponent<AudioSource>();

        if (observer)
        {
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnDestroy()
    {
        if (observer)
        {
            observer.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        if (status.Status == Status.TRACKED || status.Status == Status.EXTENDED_TRACKED)
        {
            currentVisibleTarget = this;
        }
        else
        {
            if (currentVisibleTarget == this)
                currentVisibleTarget = null;
        }
    }

    public void PlayMyAudio()
    {
        if (audioSource && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
