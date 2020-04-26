using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnswerNumber : MonoBehaviour{

    public int numberOnCube;
    public Text answerNumber;

   public Rigidbody obstacle;
   public Rigidbody player;
    public int currentScene;

    //number value
    public Text value;
    

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;


        if (answerNumber.text == "")
        {
            if (currentScene == 1)
            {
                numberOnCube = UnityEngine.Random.Range(3, 15);
            }
            else if (currentScene == 2)
            {
                numberOnCube = UnityEngine.Random.Range(0, 10);
            }
            else if (currentScene == 3)
            {
                numberOnCube = UnityEngine.Random.Range(0, 6);
            }
            else if (currentScene == 4)
            {
                numberOnCube = UnityEngine.Random.Range(6, 16);
            }
            else if (currentScene == 5)
            {
                numberOnCube = UnityEngine.Random.Range(6, 20);
            }else if (currentScene == 6)
            {
                numberOnCube = UnityEngine.Random.Range(1, 10);
            }else if (currentScene == 7)
            {
                numberOnCube = UnityEngine.Random.Range(11, 26);
            }else if (currentScene == 8)
            {
                numberOnCube = UnityEngine.Random.Range(16, 30);
            }else if (currentScene == 9)
            {
                numberOnCube = UnityEngine.Random.Range(1, 13);
            }else if (currentScene == 10)
            {
                numberOnCube = UnityEngine.Random.Range(1, 5);
            }else if (currentScene == 11)
            {
                numberOnCube = UnityEngine.Random.Range(15, 35);
            }else if (currentScene == 12)
            {
                numberOnCube = UnityEngine.Random.Range(25, 50);
            }else if (currentScene == 13)
            {
                numberOnCube = UnityEngine.Random.Range(5, 14);
            }else if (currentScene == 14)
            {
                numberOnCube = UnityEngine.Random.Range(1, 5);
            }else if (currentScene == 15)
            {
                numberOnCube = UnityEngine.Random.Range(15, 35);
            }else if (currentScene == 16)
            {
                numberOnCube = UnityEngine.Random.Range(25, 50);
            }else if (currentScene == 17)
            {
                numberOnCube = UnityEngine.Random.Range(25, 17);
            }else if (currentScene == 18)
            {
                numberOnCube = UnityEngine.Random.Range(1, 6);
            }else if (currentScene == 19)
            {
                numberOnCube = UnityEngine.Random.Range(18, 36);
            }else if (currentScene == 20)
            {
                numberOnCube = UnityEngine.Random.Range(30, 70);
            }else if (currentScene == 21)
            {
                numberOnCube = UnityEngine.Random.Range(6, 20);
            }else if (currentScene == 22)
            {
                numberOnCube = UnityEngine.Random.Range(1, 6);
            }else if (currentScene == 23 || currentScene == 27|| currentScene == 31)
            {
                numberOnCube = UnityEngine.Random.Range(22, 45);
            }else if (currentScene == 24 || currentScene == 28|| currentScene == 32)
            {
                numberOnCube = UnityEngine.Random.Range(35, 80);
            }else if (currentScene == 25 || currentScene == 29|| currentScene == 33)
            {
                numberOnCube = UnityEngine.Random.Range(6, 20);
            }else if (currentScene == 26 || currentScene == 30|| currentScene == 34)
            {
                numberOnCube = UnityEngine.Random.Range(3, 12);
            }else if (currentScene == 35)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 36)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 37)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 38)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 39)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 40)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 41)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 42)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 43)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 44)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 45)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 46)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 47)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 48)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 49)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }else if (currentScene == 50)
            {
                numberOnCube = UnityEngine.Random.Range(0, 0);
            }
            answerNumber.text = numberOnCube.ToString();
        }


    }


}
