using System;
using System.Collections;
using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private Image overlay;
    [SerializeField] private int nextLevelID;


    void Start()
    {
        gameOverMenu.SetActive(false);
        overlay.CrossFadeAlpha(0, 1f,true);
    }
    
    
    private void OnEnable()
    {
        GameEvents.RaceEnd += ShowGameOveMenu;
    }
    
    private void OnDisable()
    {
        GameEvents.RaceEnd -= ShowGameOveMenu;
    }


    private void ShowGameOveMenu()
    {
        gameOverMenu.SetActive(true);
    }

    public void Retry()
    {
        Debug.Log("retry");
        StartCoroutine(LoadLevelCoroutine(SceneManager.GetActiveScene().buildIndex));
    }

    public void NextRace()
    {
        Debug.Log("Next");
        StartCoroutine(LoadLevelCoroutine(nextLevelID));
    }
    
    private IEnumerator LoadLevelCoroutine(int levelID)
    {
        overlay.CrossFadeAlpha(1, 1f, true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    
    public void Quit()
    {
        Debug.Log("quit");
        StartCoroutine(QuitCoroutine());
    }
    
    private IEnumerator QuitCoroutine()
    {
        overlay.CrossFadeAlpha(1, 1f, true);
        yield return new WaitForSeconds(1);
        Application.Quit();
        
    }


}

