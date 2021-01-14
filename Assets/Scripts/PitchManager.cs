using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchManager : MonoBehaviour
{

    private AudioSource audioSource;
    private float timerNow;
    private float value;
    private float timeUpdate = 300;


    // Start is called before the first frame update
    void Start()
    {
        //timerNow = GetComponent<timer>().timeRemaining;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timerNow = GetComponent<timer>().timeRemaining;
        Debug.Log(timeUpdate + "  " + timerNow );
        if (timerNow < timeUpdate)
        {
            Debug.Log("opa");
            audioSource.pitch = audioSource.pitch + 0.05f;
            timeUpdate = timeUpdate - 30;

        }

    }
}
