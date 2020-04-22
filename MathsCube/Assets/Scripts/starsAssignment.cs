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

    int m_Score;
    private void Start()
    {
        SetText();

        
            if (m_Score == 1)
            {
                Star1.SetActive(true);
            }
            
            if (m_Score == 2)
            {
                Star1.SetActive(true);
                Star3.SetActive(true);
            }
            
            if (m_Score == 3)
            {
                Star1.SetActive(true);
                Star2.SetActive(true);
                Star3.SetActive(true);
            }

    }

    void SetText()
    {
        //Fetch the score from the PlayerPrefs (set these Playerprefs in another script). If no Int of this name exists, the default is 0.
        m_Score = PlayerPrefs.GetInt(LevelButton.name, 0);
        Debug.Log(m_Score);
    }
}
