using System;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip playerHurtSound;
    [SerializeField] private AudioClip playerPenaltySound;

    private void OnEnable()
    {
        GameEvents.TakeDamage += PlayHurtSound;
        GameEvents.RacePenalty += PlayPenaltySound;
    }

    private void OnDisable()
    {
        GameEvents.TakeDamage -= PlayHurtSound;
        GameEvents.RacePenalty -= PlayPenaltySound;
    }

    private void PlayPenaltySound()
    {
        source.PlayOneShot(playerPenaltySound);
    }
    
    private void PlayHurtSound()
    {
        source.PlayOneShot(playerHurtSound);
    }
}
