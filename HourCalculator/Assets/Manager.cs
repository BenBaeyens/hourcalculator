using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Manager : MonoBehaviour
{


    public TextMeshProUGUI currenthr12;
    public TextMeshProUGUI currenthr24;


    int hours;
    int minutes;
    int seconds;

    string time;


    private void Start() {
        InvokeRepeating("CurrentTime", 0f, 0.5f);
    }

    public void CurrentTime() {
        Debug.Log(DateTime.Now.TimeOfDay.ToString());
        string[] temp = DateTime.Now.TimeOfDay.ToString().Split(':');
        temp[2] = temp[2].Substring(0, 2);
        Debug.Log(hours + ":" + minutes + ":" + seconds);
        hours = int.Parse(temp[0]);
        minutes = int.Parse(temp[1]);
        seconds = int.Parse(temp[2]);

        currenthr24.text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);

        if (hours > 12)
        {
            hours -= 12;
            currenthr12.text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds) + " PM";
        } else
        {
            currenthr12.text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds) + " AM";

        }



    }


}
