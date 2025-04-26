using System;
using UnityEngine;

public class GameData : MonoBehaviour
{

    public int racesCompleted = 0;
    public static GameData instance;


    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
