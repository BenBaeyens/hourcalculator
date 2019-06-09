using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.Animations;

public class Manager : MonoBehaviour
{


    public TextMeshProUGUI currenthr12;
    public TextMeshProUGUI currenthr24;

    public TextMeshProUGUI customhr12;
    public TextMeshProUGUI customhr24;

    public TextMeshProUGUI customtimetext;


    int hours;
    int minutes;
    int seconds;

    string time;

    public Animator animator;


    private void Start() {
        animator = GetComponent<Animator>();
        InvokeRepeating("CurrentTime", 0f, 0.5f);
    }

    public void CustomTime(string s)
    {
        if(s == "Midnight")
        {
            customhr12.text = "12:00:00 AM";
            customhr24.text = "00:00:00";
            
        }
        if (s == "Midday")
        {
            customhr12.text = "12:00:00 PM";
            customhr24.text = "12:00:00";
            
        }
        if (s == "Evening")
        {
            
            customhr12.text = "06:00:00 PM";
            customhr24.text = "16:00:00";
            
        }
        if (s == "Morning")
        {
            customhr12.text = "06:00:00 AM";
            customhr24.text = "06:00:00";
            
        }
        Animation();
        customtimetext.text = s;
    }

    void Animation()
    {
        animator.SetTrigger("CustomTime2Open");
    }

    public void CurrentTime() {
       
        string[] temp = DateTime.Now.TimeOfDay.ToString().Split(':');
        temp[2] = temp[2].Substring(0, 2);
       
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
