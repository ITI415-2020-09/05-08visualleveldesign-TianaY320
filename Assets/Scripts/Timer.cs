using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 100;
    public bool timerIsRunning = false;
    public Text timeText;
    
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        GameObject timerGO = GameObject.Find("Timer");
        timeText = timerGO.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{10:00}", minutes, seconds);
    }
}
