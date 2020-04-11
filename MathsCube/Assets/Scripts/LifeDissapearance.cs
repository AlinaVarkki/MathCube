using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDissapearance : MonoBehaviour
{

    public Image fadingHeart;

    // Start is called before the first frame update
    void Start()
    {
        fadingHeart.canvasRenderer.SetAlpha(1.0f);
    }

    public void fadeOut()
    {
        fadingHeart.CrossFadeAlpha(0, 2, false);
    }
}
