using System.Collections.Generic;
using UnityEngine;

public class ObstaclesArray : MonoBehaviour
{
    public AnswerNumber[] obstaclesArray;
    //aka hashmap to store equation number ad randomly assigned cube
    //to check if player is futher
    private Dictionary<int, int> equationAndndomCube = new Dictionary<int, int>();
    public Rigidbody player;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    //if cube with answer is passed, equation has to be changed

    void Update()
    {

        //if cube is futher than the right answer cube, assigned to the current equation -> next equation
        if (player.position.z > obstaclesArray[equationAndndomCube[FindObjectOfType<EquationGenerator>().currentEquationNumber]].transform.position.z)
        {
            FindObjectOfType<EquationGenerator>().NextEquation();
        }
        

    }

    //method to give cube answers for equations
    //cubes cannot be closer than 3 cubes apart and then it's random cube within 8 for the equation 
    //called after arrays with variables are populated
    public void AssignCubesRightAnswers()
    {
        //starting with 3 to not place anything on first 3 cubes
        int Nextgroup = 3;

        //assign all cubes with a difference right numbers
        //there will be 10 equations in the round
        for (int i = 0; i < 10; i++)
        {
            
            

            //random withing group of  8 after 3 cubes
            int randomCubeNumber = Random.Range(Nextgroup, Nextgroup + 8);
            int answer = FindObjectOfType<EquationGenerator>().numbers1[i] * FindObjectOfType<EquationGenerator>().numbers2[i];

            Debug.Log(answer);

            equationAndndomCube.Add(i, randomCubeNumber);
            obstaclesArray[randomCubeNumber].answerNumber.text = answer.ToString();

            Nextgroup = Nextgroup + 8 + 3;

            //obstaclesArray[randomCubeNumber].tag = "Answer";

            ////going through the array and changing tag to answer if some othe answer is same
            ////hope it works
            //foreach (AnswerNumber an in obstaclesArray)
            //{
            //    //if the number is answer, change tag
            //    if (an.answerNumber.text == answer.ToString())
            //    {
            //        an.tag = "Answer";
            //    }
            //}
        }
    }

}
