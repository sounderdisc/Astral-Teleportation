using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{ 

    float currentTime;
    int seconds;
    int minutes;
    

    [SerializeField] Text countDownText;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize the timer to the initial time
        currentTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Increase current time by 1 in real time, not by fps
        currentTime += 1 * Time.deltaTime;
        // seperate into minutes and seconds
        minutes = (int)currentTime / 60;
        seconds = (int)currentTime - ((int)currentTime / 60);
        // make sure seconds displays correctly, adding a 0 for seconds less than 10
        if (seconds >= 10)
            countDownText.text = minutes + ":" + seconds;
        else
            countDownText.text = minutes + ":0" + seconds;
    }

}
