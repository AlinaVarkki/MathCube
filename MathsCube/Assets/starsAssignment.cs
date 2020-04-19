using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class starsAssignment : MonoBehaviour
{

    public Button LevelButton;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;


    private void Start()
    {
        Debug.Log(LevelButton.ToString());
        
            if (PlayerPrefs.GetInt(LevelButton.ToString()) == 1)
            {
                Star1.SetActive(true);
            }
            
            if (PlayerPrefs.GetInt(LevelButton.ToString()) == 2)
            {
                Star1.SetActive(true);
                Star2.SetActive(true);
            }
            
            if (PlayerPrefs.GetInt(LevelButton.ToString()) == 3)
            {
                Star1.SetActive(true);
                Star2.SetActive(true);
                Star3.SetActive(true);
            }


        



    }


}
