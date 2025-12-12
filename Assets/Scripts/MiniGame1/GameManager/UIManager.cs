using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace MiniGame1.GameManager
{
    

public class UIManager : MonoBehaviour
{
    [Header("UI Parameters")]
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject playPanel;
    [SerializeField] private ScoreManager scoreManager;
     [SerializeField] private TMP_Text finalScore;
    

    public void YouLose()
    {
        losePanel.SetActive(true);
        Time.timeScale = 0;
        MiniGame1.AudioManager.Instance.StopMusic();
        finalScore.text = scoreManager.GetScore().ToString("D7");
    }

    public void PlayGame()
    {
        playPanel.SetActive(false);
        Time.timeScale = 1;
    }

    private void Awake()
    {
        Time.timeScale = 0;
        losePanel.SetActive(false);
    }
}
}