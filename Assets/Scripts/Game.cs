using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public List<GameObject> bullets = new List<GameObject>();
    public int shots = 0;
    public int hits = 0;

    [SerializeField]
    private Text hitsText;
    [SerializeField]
    private Text shotsText;
    [SerializeField]
    private GameObject menu;
    [SerializeField]
    private GameObject[] targets;

    public static int points = 0;
    public Text PointsRemaining;
    public static int lives = 9;
    public Text LivesRemaining;
    private bool isPaused = false;

    private void Awake()
    {
        //Pause();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void Pause()
    {
        Debug.Log("Game Paused");
        menu.SetActive(true);
        Cursor.visible = true;
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Unpause()
    {
        menu.SetActive(false);
        //Cursor.visible = false;
        Time.timeScale = 1f;
        isPaused = false;
    }

    public bool IsGamePaused()
    {
        return isPaused;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPaused)
            {
                Unpause();
            }
            else
            {
                Pause();
            }
        }
        PointsRemaining.text = points.ToString();
        LivesRemaining.text = lives.ToString();
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt("lives", lives);
        PlayerPrefs.SetInt("points", points);
        //PlayerPrefs.SetFloat("time", time);
    }

    public void NewGame()
    {
        lives = 9;
        points = 0;
        TimeManager.resetTime();
        


        // voodoo below
        hits = 0;
        shots = 0;
        shotsText.text = "Shots: " + shots;
        hitsText.text = "Hits: " + hits;
        Unpause();
    }

    public void LoadGame()
    {
        lives = PlayerPrefs.GetInt("lives");
        
        points = PlayerPrefs.GetInt("points");
        
        //time = PlayerPrefs.GetFloat("time");
        //
    }

    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
    }
    public void StartPlay()
    {
        SceneManager.LoadScene("2Game");
    }

    public void DonePlaying()
    {
        SceneManager.LoadScene("3Exit");
    }

    public void Restart() 
    {
        StartPlay();
    }
    public void ExitGame()
    {
        
        Application.Quit();
        
    }

    public void DecreasePoints()
    {
        points -= 1;
        //PointsRemaining.text = points.ToString();
        Debug.Log(points);
    }
    public void IncreasePoints()
    {
        points += 1;
        //PointsRemaining.text = points.ToString();
        Debug.Log(points);
    }

    public void updatePoints() {
        //PointsRemaining.text = points.ToString();
    }

    public void DecreaseLives()
    {
        lives -= 1;
        LivesRemaining.text = lives.ToString();
        Debug.Log(lives);
    }
    public void IncreaseLives()
    {
        lives += 1;
        LivesRemaining.text = lives.ToString();
        Debug.Log(lives);
    }

    private Save CreateSaveGameObject()
    {
        Save save = new Save();
        save.points = points;
        save.lives = lives;
        save.timeLeft = TimeManager.getTime();
        return save;
    }
}