using UnityEngine;
using UnityEngine.UI;

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
    

    // Start is called before the first frame update
    void Start()
    {
        //fill arrays with numbers at the beginning 
        FillArrays();



        FindObjectOfType<ObstaclesArray>().AssignCubesRightAnswers();

        NextEquation();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FillArrays()
    {
        numbers1 = new int[10];
        numbers1 = new int[10];

        for (int i = 0; i < 10; i++)
        {
            numbers1[i] = Random.Range(0, 3);
            numbers2[i] = Random.Range(0, 3);
        }
    }

    public void NextEquation()
    {
        if (currentEquationNumber <numbers1.Length)
        {
            firstVar = numbers1[currentEquationNumber];
            secondVar = numbers2[currentEquationNumber];
            equation.text = firstVar + " * " + secondVar;
            currentEquationNumber++;
        }
        else {
            equation.text = "Good job!";
        }




        //assign correct tags to current equation right answers
        for (int i = 0;  i < FindObjectOfType<ObstaclesArray>().obstaclesArray.Length; i++)
        {
            Debug.Log("22222222222");
            if (FindObjectOfType<ObstaclesArray>().obstaclesArray[i].answerNumber.text == (firstVar * secondVar).ToString() && FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag != "OriginalAnswer")
            {
                Debug.Log(i);
                FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag = "Answer";
            }
            else if (FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag == "OriginalAnswer")
            {

                //don't do anything in this case
            }
            else {
                //if answer of cube is not current equation answer, tag is obstacle
                FindObjectOfType<ObstaclesArray>().obstaclesArray[i].tag = "Obstacle";
            }
        }



    }

}
