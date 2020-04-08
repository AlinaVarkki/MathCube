using UnityEngine;

public class DisableCanvas : MonoBehaviour
{
    public Canvas numberCanvas;
    public Rigidbody rb;
    public Rigidbody obstacle;

    // Update is called once per frame
    void Update()
    {
        //if position of cube is futher, disable canvas

        if (rb.position.z > obstacle.position.z)
        {
            numberCanvas.enabled = false;
        }
    }
}
