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
            }
            answerNumber.text = numberOnCube.ToString();
        }


    }


}
