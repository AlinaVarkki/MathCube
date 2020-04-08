using UnityEngine;

public class DisableCanvas : MonoBehaviour
{
    public Canvas numberCanvas;
    public Rigidbody rb;
    public Rigidbody obstacle;

    // Update is called once per frame
    void Update()
    {

        //only enable canvas when player is on a certain distance
        if (obstacle.position.z  - rb.position.z < 50f)
        {
            numberCanvas.enabled = true;
        }

        //if position of cube is futher, disable canvas

        if (rb.position.z > obstacle.position.z)
        {
            numberCanvas.enabled = false;
        }
    }
}
