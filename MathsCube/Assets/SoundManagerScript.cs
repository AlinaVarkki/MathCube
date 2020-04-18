using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip hitObstacle;
    static AudioSource audioSrc;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        hitObstacle = Resources.Load<AudioClip>("BreakObstacle");
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "BreakObstacle":
                audioSrc.PlayOneShot(hitObstacle);
                break;
        }
    }
}
