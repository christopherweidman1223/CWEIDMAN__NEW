using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChaosBallTimer : MonoBehaviour
{
    public TMP_Text timerText;

    private float elapsedTime = 0f;
    private bool timerRunning = true;

    void Update()
    {
        if (timerRunning)
        {
            elapsedTime += Time.deltaTime;

            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);

            timerText.text = "Time: " +
                minutes.ToString("00") + ":" +
                seconds.ToString("00");
        }
    }

    public void StopTimer()
    {
        timerRunning = false;
        timerText.text = "You Won! Time: " +
            elapsedTime.ToString("F2") + " seconds";
    }
}