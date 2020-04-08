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
        GenerateEquation();   
    }

    // Update is called once per frame
    void Update()
    {

    }

    //method called to generage equation
    public void GenerateEquation()
    {
        firstVar = Random.Range(0, 10);
        secondVar = Random.Range(0, 10);
        equation.text = firstVar + " * " + secondVar;
    }

}
