using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    //public int startTime;
    public float timeRemaining = 151;
    public bool timerIsRunning = false;
    public Text timerObject;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
    }



    // Update is called once per frame
    void Update()
    {
        
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                
            }
            else
            {
                Debug.Log("foi");
                timeRemaining = 0;
                timerIsRunning = false;
                Application.Quit();
            }
            timerObject.text = DisplayTime(timeRemaining);
        }

           
    }

    string DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        return minutes + ":" + seconds;
    }
}
   
