using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public float countdownDuration = 10f; // The duration of the countdown in seconds

    private void Start()
    {
        // Start the countdo wn when the script is attached
        StartCountdown();
    }

    private void Update()
    {
        // Keep updating the countdown until it reaches zero
        while (countdownDuration > 0f)
        {
            // Decrease the countdown duration
            countdownDuration -= Time.deltaTime;

            // Log the current countdown value
            Debug.Log("Countdown: " + countdownDuration.ToString("F2"));
        }

        // The countdown has reached zero
        CountdownFinished();
    }

    private void StartCountdown()
    {
        Debug.Log("Countdown started.");
    }

    private void CountdownFinished()
    {
        Debug.Log("Countdown finished.");
    }
}

