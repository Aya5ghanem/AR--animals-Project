using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCurrentTargetAudio : MonoBehaviour
{
    public void OnPlayButtonPressed()
    {
        if (TargetAudioHandler.currentVisibleTarget != null)
        {
            TargetAudioHandler.currentVisibleTarget.PlayMyAudio();
        }
        else
        {
            Debug.Log("No target is currently visible!");
        }
    }
}
