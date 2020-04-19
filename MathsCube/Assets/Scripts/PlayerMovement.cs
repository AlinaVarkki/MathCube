using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour{




    public Rigidbody rb;

    public GameObject finishPanel;

    public float forwardForce = 2000f;
    public float sidewaysForce = 5000f;
    private float screenCenterX;
    public float decreasingSpeed = 1;

    public bool decreasing = false;
    public bool once;

    public AudioSource moveSound;

    // Start is called before the first frame update
    private void Start()
    {


        // save the horizontal center of the screen
        screenCenterX = Screen.width * 0.5f;
        once = true;
    }

    
    // Update is called once per frame
    void Update()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        if (decreasing == true)
        {
            sidewaysForce = 0f;
            forwardForce = forwardForce - 100f;
        }

        if(forwardForce < 200f)
        {
            forwardForce = 0f;
            
            FindObjectOfType<EquationGenerator>().finishLevelPanel.SetActive(true);
        }
        

        if (Input.touchCount > 0)
        {
            

            Touch firstTouch = Input.GetTouch(0);

            // if it began this frame
            if (firstTouch.phase == TouchPhase.Began)
            {
                if (firstTouch.position.x > screenCenterX)
                {
                   
                    // if the touch position is to the right of center
                    // move right
                    //Debug.Log("RIGHT");
                    moveSound.Play();
                    rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

                }
                else if (firstTouch.position.x < screenCenterX)
                {
                    moveSound.Play();
                    //Debug.Log("LEFT");
                    rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

                }
            }

        }

        if (rb.position.y < -5.96f)
        {

            if (FindObjectOfType<Score>().score > 2 && once == true)
            {
                rb.GetComponent<AdManager>().showAd();
                once = false;

            }

            //if score is more than 6, finish with panel
            if (FindObjectOfType<Score>().score > 5)
            {
                FindObjectOfType<LevelComplete>().AssignStars();
                FindObjectOfType<EquationGenerator>().finishLevelPanel.SetActive(true);
            }
            else {
                FindObjectOfType<GameManager>().EndGame();
            }
        }


                if (FindObjectOfType<ObstaclesArray>().cubeAndlocation[FindObjectOfType<EquationGenerator>().currentEquationNumber - 1].z < rb.position.z )
                // if (Vector3.Distance(FindObjectOfType<ObstaclesArray>().cubeAndlocation[FindObjectOfType<EquationGenerator>().currentEquationNumber], rb.position) > 1.0)
                {
                    
                    FindObjectOfType<EquationGenerator>().NextEquation();

                }
            
        


    }
}
