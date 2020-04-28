using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EquationGenerator : MonoBehaviour
{

    public Text equation;
    public int firstVar;
    public int secondVar;
    //arrays to hold first and second values generated for the equation
    //10 values in the round
    public int[] numbers1;
    public int[] numbers2;
    public int currentEquationNumber = 0;
    public int currentScene;
    

    //panel appearing after last equation
    public GameObject finishLevelPanel;



    // Start is called before the first frame update
    void Start()
    {
        

        equation.fontSize = 65;
        

        currentScene = SceneManager.GetActiveScene().buildIndex;


        //fill arrays with numbers at the beginning 
        FillArrays();



        FindObjectOfType<ObstaclesArray>().AssignCubesRightAnswers();

        NextEquation();

    }


    private void FillArrays()
    {

        numbers1 = new int[10];
        numbers1 = new int[10];

        //generated numbers depend on the current level number
        if (currentScene == 1) {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(1, 9);
                numbers2[i] = Random.Range(1, 9);
            }
        }else if (currentScene == 2) {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(1, 5);
                numbers2[i] = Random.Range(1, 5);
            }
        }
        else if (currentScene == 3) {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(1, 10);
                numbers2[i] = Random.Range(0, numbers1[i]);
            }
        }
        else if (currentScene == 4) {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(1, 12);
                numbers2[i] = Random.Range(1, 12);
            }
        }
        else if (currentScene == 5) {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(2, 6);
                numbers2[i] = Random.Range(2, 6);
            }
        }
        else if (currentScene == 6)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(2, 15);
                numbers2[i] = Random.Range(1, numbers1[i]);
            }
        }else if (currentScene == 7)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(3, 15);
                numbers2[i] = Random.Range(3, 15);
            }
        }else if (currentScene == 8)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(3, 7);
                numbers2[i] = Random.Range(3, 7);
            }
        }else if (currentScene == 9)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(3, 18);
                numbers2[i] = Random.Range(2, numbers1[i]);
            }
        }else if (currentScene == 10)
        {
            for (int i = 0; i < 10; i++)
            {
                //for division
                int num1 = Random.Range(1, 5);
                int num2 = Random.Range(1, 5);
                int ans = num1 * num2;

                numbers1[i] = ans;
                numbers2[i] = num1;
            }
        }
        
        else if (currentScene == 11)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(5, 20);
                numbers2[i] = Random.Range(5, 20);
            }
        }else if (currentScene == 12)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(4, 8);
                numbers2[i] = Random.Range(4, 8);
            }
        }else if (currentScene == 13)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(4, 25);
                numbers2[i] = Random.Range(3, numbers1[i]);
            }
        }else if (currentScene == 14)
        {
            for (int i = 0; i < 10; i++)
            {
                //for division
                int num1 = Random.Range(2, 6);
                int num2 = Random.Range(2, 6);
                int ans = num1 * num2;

                numbers1[i] = ans;
                numbers2[i] = num1;
            }
        }else if (currentScene == 15)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(5, 20);
                numbers2[i] = Random.Range(5, 20);
            }
        }
        else if (currentScene == 16)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(4, 8);
                numbers2[i] = Random.Range(4, 8);
            }
        }else if (currentScene == 17)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(5, 28);
                numbers2[i] = Random.Range(4, numbers1[i]);
            }
        }else if (currentScene == 18)
        {
            for (int i = 0; i < 10; i++)
            {
                //for division
                int num1 = Random.Range(2, 8);
                int num2 = Random.Range(2, 8);
                int ans = num1 * num2;

                numbers1[i] = ans;
                numbers2[i] = num1;
            }
        }
        
        else if (currentScene == 19)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(6, 22);
                numbers2[i] = Random.Range(6, 22);
            }
        }
        else if (currentScene == 20)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(5, 9);
                numbers2[i] = Random.Range(5, 9);
            }
        }else if (currentScene == 21)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(9, 32);
                numbers2[i] = Random.Range(4, numbers1[i]);
            }
        }else if (currentScene == 22)
        {
            for (int i = 0; i < 10; i++)
            {
                //for division
                int num1 = Random.Range(3, 9);
                int num2 = Random.Range(3, 9);
                int ans = num1 * num2;

                numbers1[i] = ans;
                numbers2[i] = num1;
            }
        }
        else if (currentScene == 23 || currentScene == 27|| currentScene == 31)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(8, 25);
                numbers2[i] = Random.Range(8, 25);
            }
        }
        else if (currentScene == 24||currentScene == 28||currentScene == 32)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(5, 10);
                numbers2[i] = Random.Range(5, 10);
            }
        }else if (currentScene == 25 || currentScene == 29|| currentScene == 33)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(9, 40);
                numbers2[i] = Random.Range(6, numbers1[i]);
            }
        }else if (currentScene == 26 || currentScene == 30|| currentScene == 34)
        {
            for (int i = 0; i < 10; i++)
            {
                //for division
                int num1 = Random.Range(4, 14);
                int num2 = Random.Range(4, 14);
                int ans = num1 * num2;

                numbers1[i] = ans;
                numbers2[i] = num1;
            }
        }
        
        
        
        else if (currentScene == 35 || currentScene == 39)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(8, 26);
                numbers2[i] = Random.Range(8, 26);
            }
        }
        else if (currentScene == 36 || currentScene == 40)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(5, 11);
                numbers2[i] = Random.Range(5, 11);
            }
        }else if (currentScene == 37 || currentScene == 41)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(10, 45);
                numbers2[i] = Random.Range(8, numbers1[i]);
            }
        }else if (currentScene == 38 || currentScene == 42)
        {
            for (int i = 0; i < 10; i++)
            {
                //for division
                int num1 = Random.Range(4, 16);
                int num2 = Random.Range(4, 16);
                int ans = num1 * num2;

                numbers1[i] = ans;
                numbers2[i] = num1;
            }
        }
        

        else if (currentScene == 43 || currentScene == 47)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(10, 30);
                numbers2[i] = Random.Range(10, 30);
            }
        }
        else if (currentScene == 44 || currentScene == 48)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(6, 12);
                numbers2[i] = Random.Range(6, 12);
            }
        }else if (currentScene == 45 || currentScene == 49)
        {
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = Random.Range(10, 55);
                numbers2[i] = Random.Range(8, numbers1[i]);
            }
        }else if (currentScene == 46 || currentScene == 50)
        {
            for (int i = 0; i < 10; i++)
            {
                //for division
                int num1 = Random.Range(4, 20);
                int num2 = Random.Range(4, 20);
                int ans = num1 * num2;

                numbers1[i] = ans;
                numbers2[i] = num1;
            }
        }



    }

    public void NextEquation()
    {
       if (currentEquationNumber <numbers1.Length)
      
        {
            firstVar = numbers1[currentEquationNumber];
            secondVar = numbers2[currentEquationNumber];
            
            //sign depends on the current scene
            if (currentScene == 1 || currentScene == 4 || currentScene == 7|| currentScene == 11|| currentScene == 15 || currentScene == 19 || currentScene == 23 || currentScene == 27 || currentScene == 31 || currentScene == 35 || currentScene == 39 || currentScene == 43 || currentScene ==47)
            {
                equation.text = firstVar + " + " + secondVar;
            }
            else if (currentScene == 2 || currentScene == 5|| currentScene == 8|| currentScene == 12|| currentScene == 16 || currentScene == 20 || currentScene == 24 || currentScene == 28 || currentScene == 32 || currentScene == 36 || currentScene == 40 || currentScene == 44 || currentScene == 48)
            {
                equation.text = firstVar + " * " + secondVar;
            }
            else if (currentScene == 3 || currentScene == 6|| currentScene == 9|| currentScene == 13 || currentScene == 17 || currentScene == 21 || currentScene == 25 || currentScene == 29 || currentScene == 33 || currentScene == 37 || currentScene == 41 || currentScene == 45 || currentScene == 49)
            {
                equation.text = firstVar + " - " + secondVar;
            }else if (currentScene == 10 || currentScene == 14 || currentScene == 18 || currentScene == 22 || currentScene == 26 || currentScene == 30 || currentScene == 34 || currentScene == 38 || currentScene == 42 || currentScene == 46 || currentScene == 50)
            {
                equation.text = firstVar + " / " + secondVar;
            }

            currentEquationNumber++;
        }
        else {


            //activate levelover panel
            FindObjectOfType<PlayerMovement>().decreasing = true;

            
            
            
            //finishPanel is activated in PlayerMovement when the time stops



            //methods called after activation
            FindObjectOfType<LevelComplete>().AssignStars();


            

            equation.text = "Good job!";

        }





        //assign correct tags to current equation right answers
        if (currentScene == 1 || currentScene == 4 || currentScene == 7 || currentScene == 11 || currentScene == 15 || currentScene == 19 || currentScene == 23 || currentScene == 27 || currentScene == 31 || currentScene == 35 || currentScene == 39 || currentScene == 43 || currentScene == 47)
        {
            for (int i = 0; i < FindObjectOfType<ObstaclesArray>().obstaclesArray.Length; i++)
            {

                if (FindObjectOfType<ObstaclesArray>().obstaclesArray[i].answerNumber.text == (firstVar + secondVar).ToString() && FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag != "OriginalAnswer")
                {

                    FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag = "Answer";
                }
                else if (FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag == "OriginalAnswer")
                {

                    //don't do anything in this case
                }
                else
                {
                    //if answer of cube is not current equation answer, tag is obstacle
                    FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag = "Obstacle";
                }
            }
        }
        else if (currentScene == 2 || currentScene == 5 || currentScene == 8 || currentScene == 12 || currentScene == 16 || currentScene == 20 || currentScene == 24 || currentScene == 28 || currentScene == 32 || currentScene == 36 || currentScene == 40 || currentScene == 44 || currentScene == 48) {
            for (int i = 0; i < FindObjectOfType<ObstaclesArray>().obstaclesArray.Length; i++)
            {

                if (FindObjectOfType<ObstaclesArray>().obstaclesArray[i].answerNumber.text == (firstVar * secondVar).ToString() && FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag != "OriginalAnswer")
                {

                    FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag = "Answer";
                }
                else if (FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag == "OriginalAnswer")
                {

                    //don't do anything in this case
                }
                else
                {
                    //if answer of cube is not current equation answer, tag is obstacle
                    FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag = "Obstacle";
                }
            }
        }
        else if (currentScene == 3 || currentScene == 6 || currentScene == 9 || currentScene == 13 || currentScene == 17 || currentScene == 21 || currentScene == 25 || currentScene == 29 || currentScene == 33 || currentScene == 37 || currentScene == 41 || currentScene == 45 || currentScene == 49) {
            for (int i = 0; i < FindObjectOfType<ObstaclesArray>().obstaclesArray.Length; i++)
            {

                if (FindObjectOfType<ObstaclesArray>().obstaclesArray[i].answerNumber.text == (firstVar - secondVar).ToString() && FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag != "OriginalAnswer")
                {

                    FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag = "Answer";
                }
                else if (FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag == "OriginalAnswer")
                {

                    //don't do anything in this case
                }
                else
                {
                    //if answer of cube is not current equation answer, tag is obstacle
                    FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag = "Obstacle";
                }
            }
        }else if (currentScene == 10 || currentScene == 14 || currentScene == 18 || currentScene == 22 || currentScene == 26 || currentScene == 30 || currentScene == 34 || currentScene == 38 || currentScene == 42 || currentScene == 46 || currentScene == 50) {
            for (int i = 0; i < FindObjectOfType<ObstaclesArray>().obstaclesArray.Length; i++)
            {

                if (FindObjectOfType<ObstaclesArray>().obstaclesArray[i].answerNumber.text == (firstVar / secondVar).ToString() && FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag != "OriginalAnswer")
                {

                    FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag = "Answer";
                }
                else if (FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag == "OriginalAnswer")
                {

                    //don't do anything in this case
                }
                else
                {
                    //if answer of cube is not current equation answer, tag is obstacle
                    FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag = "Obstacle";
                }
            }
        }




    }



}
