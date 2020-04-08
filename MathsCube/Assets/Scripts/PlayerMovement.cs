using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public Rigidbody rb;

    public float forwardForce = 20f;
    public float sideways = 500f;
    private float screenCenterX;

    // Start is called before the first frame update
    private void Start()
    {
        // save the horizontal center of the screen
        screenCenterX = Screen.width * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardForce  * Time.deltaTime);


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
                    Debug.Log("RIGHT");
                    rb.AddForce(300f * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

                }
                else if (firstTouch.position.x < screenCenterX)
                {
                    Debug.Log("LEFT");
                    rb.AddForce(-300f * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

                }
            }

        }

        if(rb.position.y < -5.96f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
