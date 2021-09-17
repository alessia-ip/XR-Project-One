using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfDay : MonoBehaviour
{
    public enum TimeOfTheDay{
        Morning,
        Afternoon,
        Evening,
        Night
    }

    public TimeOfTheDay _timeOfTheDay;

    private void Start()
    {
        var hour = System.DateTime.Now.Hour;
        if (hour >= 5 && hour < 11)
        {
            _timeOfTheDay = TimeOfTheDay.Morning;
        } else if (hour >= 11 && hour < 17)
        {
            _timeOfTheDay = TimeOfTheDay.Afternoon;
        } else if (hour >= 17 && hour < 23)
        {
            _timeOfTheDay = TimeOfTheDay.Evening;
        }
        else
        {
            _timeOfTheDay = TimeOfTheDay.Night;
        }
        
        Debug.Log(_timeOfTheDay);
    }
    
}
