using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeElapsed;
    public bool isRunning;
    public float timeDuration;

    public Timer()
    {
        timeElapsed = 0;
        isRunning = false;
    }

    public void TimerResume()
    {
        isRunning = true;
    }

    public void TimerStop()
    {
        isRunning = false;
    }

    public bool TimerFinished()
    {
        if (timeElapsed < timeDuration && isRunning) return false;
        else return true;
    }

    public void TimerUpdate()
    {
        if (isRunning) timeElapsed += Time.deltaTime;
        else isRunning = false;
    }

    public void TimerReset()
    {
        timeElapsed = 0;
        isRunning = false;
    }

    public void SetTimer(float duration)
    {
        timeDuration = duration;
        isRunning = true;
    }
}