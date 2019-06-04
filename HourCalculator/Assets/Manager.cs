using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalculateTime(int t) {
        string[] temp = DateTime.Now.TimeOfDay.ToString().Split(':');
        hours = int.Parse(temp[0]);
        minutes = int.Parse(temp[1]);

        minutes += 14;
        for (int i = 0; i < t; i++)
        {

            hours += 1;
            minutes += 50;

            if (minutes >= 70)
            {
                minutes -= 70;
                hours++;
            }
            if (minutes >= 60)
            {
                minutes -= 60;
                hours += 1;
            }
            if (hours >= 24)
                hours -= 24;
        }

        time = string.Format("{0:00}:{1:00}", hours, minutes);

    }


}
