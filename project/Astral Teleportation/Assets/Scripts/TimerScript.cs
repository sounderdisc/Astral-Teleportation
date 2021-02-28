using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{ 

    float currentTime;
    

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
        //Decrease current time by 1 in real time, not by fps
        currentTime += 1 * Time.deltaTime;

        countDownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }

}
