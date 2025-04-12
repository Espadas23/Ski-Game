using System;
using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameEvents.CallRaceStart();
    }
}
