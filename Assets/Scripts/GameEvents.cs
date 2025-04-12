using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public delegate void GameEvent();
    public static event GameEvent TakeDamage;

    public static void CallTakeDamage()
    {
        if (TakeDamage != null)
            TakeDamage();
    }
}
