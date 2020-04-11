using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerNumber : MonoBehaviour{

    public int numberOnCube;
    public Text answerNumber;

   public Rigidbody obstacle;
   public Rigidbody player;

    //number value
    public Text value;
    

    // Start is called before the first frame update
    void Start()
    {

        if (answerNumber.text == "")
        {
            numberOnCube = UnityEngine.Random.Range(0, 10);
            answerNumber.text = numberOnCube.ToString();
        }


    }

    // Update is called once per frame
    void Update()
    {

        
        //if the body is passed 
        //check if it is answer for current equation
        //if (obstacle.tag == "OriginalAnswer" && player.position.z > obstacle.position.z && FindObjectOfType<ObstaclesArray>().cubeAndlocation[FindObjectOfType<EquationGenerator>().currentEquationNumber]) 
//       if (FindObjectOfType<ObstaclesArray>().cubeAndlocation[FindObjectOfType<EquationGenerator>().currentEquationNumber] > player.position.z) 
  //     {
    //      FindObjectOfType<EquationGenerator>().NextEquation();
            
      // }

    }

}
