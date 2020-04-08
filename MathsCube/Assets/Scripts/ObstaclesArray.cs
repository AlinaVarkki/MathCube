using System.Collections.Generic;
using UnityEngine;

public class ObstaclesArray : MonoBehaviour
{
    public AnswerNumber[] obstaclesArray;
    public EquationGenerator eg;
    public int answer;
    public int randomCubeNumber;

    // Start is called before the first frame update
    void Start()
    {
        
        //getting right answer

        //variables used in current equation
        var first = eg.firstVar;
        var second = eg.secondVar;

        Debug.Log(first);
        Debug.Log(second);

        //calculating equation answer
        answer = first * second;

        Debug.Log(answer);

        randomCubeNumber = Random.Range(0, obstaclesArray.Length - 1);
        obstaclesArray[randomCubeNumber].answerNumber.text = answer.ToString();
        obstaclesArray[randomCubeNumber].tag = "Answer";

        //going through the array and changing tag to answer if some othe answer is same
        //hope it works
        foreach(AnswerNumber an in obstaclesArray)
        {
            //if the number is answer, change tag
            if (an.answerNumber.text == answer.ToString())
            {
                an.tag = "Answer";
            }
        }


    }

    // Update is called once per frame
    void Update()
    {

    }



}
