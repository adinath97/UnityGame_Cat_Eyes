﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count_Down : MonoBehaviour
{
    public int countDownTime = 3;
    public Text countDownDisplay;
    public static bool beginGame;
    public static bool gameOver;


    private void Start()
    {
        gameOver = false;
        beginGame = false;
        StartCoroutine(CountDownRoutine());
    }

    IEnumerator CountDownRoutine()
    {
        while(countDownTime > 0)
        {
            countDownDisplay.text = countDownTime.ToString();
            yield return new WaitForSeconds(1f);
            countDownTime--;
        }
        countDownDisplay.text = "GO!";
        yield return new WaitForSeconds(1f);
        countDownDisplay.gameObject.SetActive(false);
        beginGame = true;
    }
}
