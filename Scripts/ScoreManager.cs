using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public GameObject timerText;
    public GameObject highScoreText;
    public static float limitSeconds = 31f;
    private float step = 1f;
    public static int startOrNah = 0;
    public static bool playerWon;
    public static bool stopCounting;

    private void Start()
    {
        highScoreText.GetComponent<Text>().text = "Best: " + PlayerPrefs.GetFloat("HighScore", 30f).ToString();
        timerText.GetComponent<Text>().text = "Time Left: 30";
        limitSeconds = 31f;
        playerWon = false;
        stopCounting = false;
        startOrNah = 0;
    }

    private void Update()
    {
        if (Count_Down.beginGame == true && startOrNah == 0)
        {
            StartCoroutine(TimerRoutine());
            startOrNah++;
        }
    }

    IEnumerator TimerRoutine()
    {
        //Debug.Log("1 AND NOW IS THIS WORKING. limitSeconds is " + limitSeconds);
        while (limitSeconds > 0 )
        {
            limitSeconds -= step;
            if (stopCounting == false)
            {
                timerText.GetComponent<Text>().text = "Time Left: " + limitSeconds.ToString();
                //Debug.Log("AND NOW IS THIS WORKING. limitSeconds is " + limitSeconds);
                if (limitSeconds == 0)
                {
                    playerWon = true;
                    StartCoroutine(ItsOverRoutine());
                }
                if (limitSeconds < PlayerPrefs.GetFloat("HighScore", 30f))
                {
                    PlayerPrefs.SetFloat("HighScore", limitSeconds);
                    highScoreText.GetComponent<Text>().text = "Best: " + limitSeconds.ToString();
                }
            }
            yield return new WaitForSeconds(step);
        }
    }

    IEnumerator ItsOverRoutine()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GAME_OVER_YOU_WON");
    }
}
