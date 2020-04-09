using UnityEngine;
using UnityEngine.UI;

public class EquationGenerator : MonoBehaviour
{

    public Text equation;
    public int firstVar;
    public int secondVar;
    //arrays to hold first and second values generated for the equation 
    public int[] numbers1 = new int[20];
    public int[] numbers2 = new int[20];
    private int currentEquationNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        //fill arrays with numbers at the beginning 
        FillArrays();
        NextEquation();

        //GenerateEquation();   
    }

    // Update is called once per frame
    void Update()
    {

    }


    ////method called to generage equation
    //public void GenerateEquation()
    //{
    //    firstVar = Random.Range(0, 10);
    //    secondVar = Random.Range(0, 10);
    //    equation.text = firstVar + " * " + secondVar;
    //}

    private void FillArrays()
    {
        for (int i = 0; i < 20; i++)
        {
            numbers1[i] = Random.Range(0, 10);
            numbers2[i] = Random.Range(0, 10);
        }
    }

    public void NextEquation()
    {
        firstVar = numbers1[currentEquationNumber];
        secondVar = numbers2[currentEquationNumber];
        equation.text = firstVar + " * " + secondVar;
        currentEquationNumber++;
    }

}
