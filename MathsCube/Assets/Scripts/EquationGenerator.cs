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


    }

    public void NextEquation()
    {
       if (currentEquationNumber <numbers1.Length)
      
        {
            firstVar = numbers1[currentEquationNumber];
            secondVar = numbers2[currentEquationNumber];
            
            //sign depends on the current scene
            if (currentScene == 1 || currentScene == 4)
            {
                equation.text = firstVar + " + " + secondVar;
            }
            else if (currentScene == 2 || currentScene == 5)
            {
                equation.text = firstVar + " * " + secondVar;
            }
            else if (currentScene == 3)
            {
                equation.text = firstVar + " - " + secondVar;
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
        if (currentScene == 1 || currentScene == 4)
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
        else if (currentScene == 2 || currentScene == 5) {
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
        }else if (currentScene == 3) {
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
        }




    }



}
