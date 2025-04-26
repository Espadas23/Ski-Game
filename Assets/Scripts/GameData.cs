using System;
using UnityEngine;

public class GameData : MonoBehaviour
{

    public int racesCompleted = 0;
    private static GameData instance;

    public static GameData Instance
    {
        get { return instance; }
    }


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
