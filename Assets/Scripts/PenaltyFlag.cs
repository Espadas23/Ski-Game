using UnityEngine;

public class PenaltyFlag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameEvents.CallRacePenalty();
    }
}
