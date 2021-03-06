using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public Text timeLimitText;
    public Text remainingTimeText;

    public float timelimit = 30.0f;
    public static float timeRemaining ;

    // Start is called before the first frame update
    void Start()
    {
        timelimit = PlayerPrefs.GetFloat("TimerValue");
        timeRemaining = timelimit;

        timeLimitText.text = "time limit: " + timelimit.ToString("F2");
        remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
    }


    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if(timeRemaining >= 0)
        {
            remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            SceneManager.LoadScene("3Exit");
        }

    }

    public static void resetTime() {
        timeRemaining = PlayerPrefs.GetFloat("TimerValue");
    }

    public static float getTime() {
        return timeRemaining;
    }
}
