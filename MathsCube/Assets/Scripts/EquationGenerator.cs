using UnityEngine;
using UnityEngine.UI;

public class EquationGenerator : MonoBehaviour
{

    public Text equation;
    public int firstVar;
    public int secondVar;

    // Start is called before the first frame update
    void Start()
    {
        firstVar = Random.Range(0, 10);
        secondVar = Random.Range(0, 10);
        equation.text = firstVar + " * " + secondVar;
    }

    // Update is called once per frame
    void Update()
    {

    }

    ////method that generates a random number between 0 and 9
    //int RandomNumberGen()
    //{
    //    return Random.Range(0, 10);
    //}

}
