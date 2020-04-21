﻿using System.Text;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public Text scoreText;
    public SceneFader fader;



    public Image Star1;
    public Image Star2;
    public Image Star3;

    public Image NextArrow;
    public Image Lock;

    public Button NextLevelButton;

    public string nextLevel = "Level02";
    public int levelToUnlock = 2;

    //starting from 0
    public string currentLevel = "1";

    public AudioSource finish;

    //string for button to assign stars
    public string buttonName = "LevelButton1";
    private void Start()
    {
        

    }


  

    private void Update()
    {
        scoreText.text = FindObjectOfType<Score>().score.ToString();

    }

    public void LoadNextLevel()
    {
        scoreText.GetComponent<AdManager>().showAd();
        Debug.Log("next level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void Menu()
    {
        

        scoreText.GetComponent<AdManager>().showAd();
      
            fader.FadeTo("Levels");
            SceneManager.LoadScene(0);
        
    }

    public void Retry()
    {
        scoreText.GetComponent<AdManager>().showAd();
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    public void AssignStars()
    {
        //if used passed all the obstacles, show a screen with score, if score is 6-7, give 1 star, if 8- 2 starts, 9-10 - 3 start
        //if score is more than 6, unlock next level 


        finish.Play();

        if (FindObjectOfType<Score>().score < 6)
        {
            


            //disable arrow and activate padlock
            NextArrow.enabled = false;

            Star1.enabled = false;
            Star2.enabled = false;
            Star3.enabled = false;

            //if score is smaller than 6, disable next level button
           // NextLevelButton.enabled = false;
        }
        else
        {
            WinLevel();

            Lock.enabled = false;


            //save into memore how many stars user got
            if (FindObjectOfType<Score>().score == 9 || FindObjectOfType<Score>().score == 10)
            {
                
                    PlayerPrefs.SetInt(buttonName, 3);
                
            }

            if (FindObjectOfType<Score>().score == 6 || FindObjectOfType<Score>().score == 7)
            {
                //save into memore how many stars user got
                if (PlayerPrefs.GetInt(buttonName) < 2)
                {
                    PlayerPrefs.SetInt(buttonName, 1);
                }
                Star2.enabled = false;
                Star3.enabled = false;
            }

            if (FindObjectOfType<Score>().score == 8)
            {
                //save into memore how many stars user got
                if (PlayerPrefs.GetInt(buttonName) < 3)
                {
                    PlayerPrefs.SetInt(buttonName, 2);
                }
                

                Star3.enabled = false;
            }
        }

        
    }

    public void WinLevel()
    {
        //unlock next level
        PlayerPrefs.SetInt("LevelReached", levelToUnlock);
    }
}
