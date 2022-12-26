using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinsAndButtonsHandler : MonoBehaviour
{
    private const int MinPinValue = 0;
    private const int MaxPinValue = 10;

    public Text leftPinPanelText;
    public Text centerPinPanelText;
    public Text rightPinPanelText;

    public int leftPin = 0;
    public int centerPin = 0;
    public int rightPin = 0;

    private void Update()
    {
        leftPinPanelText.text = leftPin.ToString();
        centerPinPanelText.text = centerPin.ToString();
        rightPinPanelText.text = rightPin.ToString();
    }

    public void LeftButtonAction()
    {
        if(leftPin < MaxPinValue)
        {
            leftPin += 1;
        }
        if(centerPin > MinPinValue)
        {
            centerPin -= 1;
        }
    }   
    
    public void CenterButtonAction()
    {
        if(leftPin > MinPinValue)
        {
            leftPin -= 1;
        }
        if(centerPin < MaxPinValue)
        {
            centerPin = 2;
        }
        if(rightPin > MinPinValue)
        {
            rightPin -= 1;
        }
    }
    
    public void RightButtonAction()
    {
        if(leftPin > MinPinValue)
        {
            leftPin -= 1;
        }
        if(centerPin < MaxPinValue)
        {
            centerPin += 1;
        }
        if(rightPin < MaxPinValue)
        {
            rightPin += 1;
        }
    }
}
