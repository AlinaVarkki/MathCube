using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerNumber : MonoBehaviour{

    public int numberOnCube;
    public Text answerNumber;


    // Start is called before the first frame update
    void Start()
    {
        numberOnCube = Random.Range(0, 10);
        answerNumber.text = numberOnCube.ToString();


    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 namePose = Camera.main.WorldToScreenPoint(this.transform.position);
        
       // answerNumber.transform.position = namePose;


    }



   
}
