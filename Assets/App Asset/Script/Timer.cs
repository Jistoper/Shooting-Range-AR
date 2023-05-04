using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    [HideInInspector]float currentTime = 0;

    [HideInInspector]public bool keepCount = false;

    void Update()
    {
        if (keepCount)
        {
            currentTime = currentTime += Time.deltaTime;
        }

        timerText.text = currentTime.ToString("0.00");
    }

    public void changeStatus()
    {
        if (keepCount == false)
        {
            keepCount = true;
        }
        else
        {
            keepCount = false;
            currentTime = 0;
        }
    }
}
