using System;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip playerHurtSound;

    private void OnEnable()
    {
        GameEvents.TakeDamage += PlayHurtSound;
    }

    private void OnDisable()
    {
        GameEvents.TakeDamage -= PlayHurtSound;
    }


    private void PlayHurtSound()
    {
        source.PlayOneShot(playerHurtSound);
    }
}
