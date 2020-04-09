
using UnityEngine;

public class Swipe : MonoBehaviour
{

    private bool tap, swipeLeft, swipeRight;
    private Vector2 startTouch, swipeDelta;
    private bool isDragging;


    private void Update()
    {
        tap = swipeLeft = swipeRight = false;


        if (Input.touches.Length != 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                isDragging = true;
                tap = true;
                startTouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isDragging = false;
                Reset();
            }
        }


        //calculate the distance
        swipeDelta = Vector2.zero;
        if(isDragging)
        {
            if (Input.touches.Length > 0)
            {
                swipeDelta = Input.touches[0].position - startTouch;
            }
            else if (Input.GetMouseButton(0))
            {
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
            }


            //did we cross the deadzone
            if(swipeDelta.magnitude > 100)
            {

                float x = swipeDelta.x;
                float y = swipeDelta.y;

                if(Mathf.Abs(x) > Mathf.Abs(y))
                {
                    if (x < 0)
                    {
                        swipeLeft = true;
                    }
                    else
                    {
                        swipeRight = true;
                    }
                }

                Reset();
            }
            
        }

    }

    private void Reset()
    {
        startTouch = swipeDelta = Vector2.zero;
        isDragging = false;
    }


    public Vector2 SwipeDelta { get { return swipeDelta; } }
    public bool SwipeLeft { get { return swipeLeft; } }
    public bool SwipeRight { get { return swipeRight; } }

}