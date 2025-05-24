using System;
using System.Collections;
using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private Image overlay;
    [SerializeField] private int nextLevelID;
    [SerializeField] private GameObject leaderboardPanel;
    [SerializeField] private GameObject leaderboardEntryPrefab;
    [SerializeField] private Leaderboards leaderboard;



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
        PopulateLeaderboard();
    }
    
    private void PopulateLeaderboard()
    {
        foreach (Transform child in leaderboardPanel.transform)
        {
            Destroy(child.gameObject);
        }

        var results = leaderboard.GetResults();

        for (int i = 0; i < results.Count; i++)
        {
            //GameObject go = Instantiate(leaderboardEntryPrefab, leaderboardPanel.transform);
           // TMP_Text text = go.GetComponentInChildren<TMP_Text>();
            //text.text = $"{i + 1}. {results[i]:F2} sec";
            GameObject go = Instantiate(leaderboardEntryPrefab, leaderboardPanel.transform);
            RectTransform rt = go.GetComponent<RectTransform>();
            rt.anchoredPosition3D = new Vector3(0, 0, 0);
            rt.localScale = Vector3.one;
            rt.localRotation = Quaternion.identity;
            TMP_Text text = go.GetComponentInChildren<TMP_Text>();
            text.text = $"{i + 1}. {results[i]:F2} sec";
        }
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

