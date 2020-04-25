using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstaclesArray : MonoBehaviour
{
    public AnswerNumber[] obstaclesArray;
    //aka hashmap to store equation number ad randomly assigned cube
    //to check if player is futher
    public Dictionary<int, Vector3> cubeAndlocation = new Dictionary<int, Vector3>();
    public Rigidbody player;
    public int answer;


    //method to give cube answers for equations
    //cubes cannot be closer than 3 cubes apart and then it's random cube within 8 for the equation 
    //called after arrays with variables are populated
    public void AssignCubesRightAnswers()
    {
        int currentScene = FindObjectOfType<EquationGenerator>().currentScene;
        int randomCubeNumber;
        //starting with 3 to not place anything on first 3 cubes
        int Nextgroup = 0;

        //assign all cubes with a difference right numbers
        //there will be 10 equations in the round
        for (int i = 0; i < 10; i++)
        {

            if (i == 0)
            {
                randomCubeNumber = 0;
            }
            else
            {
                //random withing group of  8 after 3 cubes
                randomCubeNumber = Random.Range(Nextgroup, Nextgroup + 8);
            }

            int firsNum = FindObjectOfType<EquationGenerator>().numbers1[i];
            int secindNum = FindObjectOfType<EquationGenerator>().numbers2[i];

            if (currentScene  == 1 || currentScene == 4)
            {
                answer = firsNum + secindNum;
            }else if (currentScene  == 2)
            {
                answer = firsNum * secindNum;
            }
            else if (currentScene  == 3)
            {
                answer = firsNum - secindNum;
            }

            obstaclesArray[randomCubeNumber].answerNumber.text = answer.ToString();

            cubeAndlocation.Add(i, obstaclesArray[randomCubeNumber].transform.position);
            
            Nextgroup = Nextgroup + 8 + 3;

            obstaclesArray[randomCubeNumber].tag = "OriginalAnswer";

        }

        
    }

}
