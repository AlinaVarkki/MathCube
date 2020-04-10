using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerNumber : MonoBehaviour{

    public int numberOnCube;
    public Text answerNumber;

   public Rigidbody obstacle;
   public Rigidbody player;
    

    // Start is called before the first frame update
    void Start()
    {

        if (answerNumber.text == "")
        {
            numberOnCube = Random.Range(0, 10);
            answerNumber.text = numberOnCube.ToString();
        }


    }

    // Update is called once per frame
    void Update()
    {

        
        //if the body is passed 
        if (obstacle.tag == "OriginalAnswer" && player.position.z > obstacle.position.z)
       {
          FindObjectOfType<EquationGenerator>().NextEquation();
            obstacle.tag = "Obstacle";
       }

    }

}
