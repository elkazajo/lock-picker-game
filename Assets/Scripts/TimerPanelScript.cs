using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerPanelScript : MonoBehaviour
{
    public Text timerPanelText;

    public float startingTime;
    private int _remainingTime;
    public bool isTimerRunning;

    public void Start()
    {
        isTimerRunning = true;
    }

    private void Update()
    {
        CountDownTimer();
    }

    private void CountDownTimer()
    {
        if (!isTimerRunning) return;
        if (startingTime > 0)
        {
            startingTime -= Time.deltaTime;
            _remainingTime = Mathf.RoundToInt(startingTime);
            timerPanelText.text = _remainingTime.ToString();
        }
        else
        {
            isTimerRunning = false;
        }
    }
}
