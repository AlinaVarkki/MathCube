using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour{


    public Transform player;
    public Text scoreText;
    private int score = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void UpdateScore()
    {
        score++;
    }
}
