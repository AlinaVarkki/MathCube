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

            if (currentScene == 1 || currentScene == 4 || currentScene == 7 || currentScene == 11 || currentScene == 15 || currentScene == 19 || currentScene == 23 || currentScene == 27 || currentScene == 31 || currentScene == 35 || currentScene == 39 || currentScene == 43 || currentScene == 47)
            {
                answer = firsNum + secindNum;
            }else if (currentScene == 2 || currentScene == 5 || currentScene == 8 || currentScene == 12 || currentScene == 16 || currentScene == 20 || currentScene == 24 || currentScene == 28 || currentScene == 32 || currentScene == 36 || currentScene == 40 || currentScene == 44 || currentScene == 48)
            {
                answer = firsNum * secindNum;
            }
            else if (currentScene == 3 || currentScene == 6 || currentScene == 9 || currentScene == 13 || currentScene == 17 || currentScene == 21 || currentScene == 25 || currentScene == 29 || currentScene == 33 || currentScene == 37 || currentScene == 41 || currentScene == 45 || currentScene == 49)
            {
                answer = firsNum - secindNum;
            }else if (currentScene == 10 || currentScene == 14 || currentScene == 18 || currentScene == 22 || currentScene == 26 || currentScene == 30 || currentScene == 34 || currentScene == 38 || currentScene == 42 || currentScene == 46 || currentScene == 50)
            {
                answer = firsNum / secindNum;
            }

            obstaclesArray[randomCubeNumber].answerNumber.text = answer.ToString();

            cubeAndlocation.Add(i, obstaclesArray[randomCubeNumber].transform.position);
            
            Nextgroup = Nextgroup + 8 + 3;

            obstaclesArray[randomCubeNumber].tag = "OriginalAnswer";

        }

        
    }

}