using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PinsAndButtonsHandler _pins;
    private TimerPanelScript _timerPanelScript;

    public Canvas mainMenu;
    public Canvas gameCanvas;
    public Canvas loseCanvas;
    public Canvas winCanvas;

    private bool _isWon;
    private bool _isLost;
    private bool _isTimerActive;
    public bool isGameStarted;

    private void Start()
    {
        mainMenu.enabled = true;
        gameCanvas.enabled = false;
        loseCanvas.enabled = false;
        winCanvas.enabled = false;
        _pins = FindObjectOfType<PinsAndButtonsHandler>();
        _timerPanelScript = FindObjectOfType<TimerPanelScript>();
    }

    private void Update()
    {
        WinCondition();
        LoseCondition();
    }

    private void WinCondition()
    {
        if (_pins.leftPin == 3 && _pins.centerPin == 2 && _pins.rightPin == 3 && !_isLost && !_isWon)
        {
            _isWon = true;
            winCanvas.enabled = true;
            gameCanvas.enabled = false;
            _timerPanelScript.isTimerRunning = false;
        }
    }

    private void LoseCondition()
    {
        if (!_timerPanelScript.isTimerRunning && !_isWon && !_isLost && isGameStarted)
        {
            loseCanvas.enabled = true;
            gameCanvas.enabled = false;
           _timerPanelScript.isTimerRunning = false;
            _isLost = true;
        }
    }

    public void RestartGame()
    {
        gameCanvas.enabled = true;
        loseCanvas.enabled = false;
        winCanvas.enabled = false;
        _timerPanelScript.isTimerRunning = true;
        _timerPanelScript.startingTime = 30f;
        _pins.leftPin = 0;
        _pins.centerPin = 0;
        _pins.rightPin = 0;
        _isLost = false;
        _isWon = false;
        isGameStarted = true;
    }
    
    public void GameStarted()
    {
        isGameStarted = true;
    }
}