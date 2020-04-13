using UnityEngine;

public class OnClickCube : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp()
    {
        if (cube)
        {
            Debug.Log("Clickeeeeeeeeed");
        }
    }
}
