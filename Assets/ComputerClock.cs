using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerClock : MonoBehaviour {

    private int testingHour;
    public int secondStarter;
    public int secondsToAlarmSet;
    public int alarmTimer;

    public Text currentTimeText;
    public Text alarmTimeText;
    public Text alarmText;


    // Use this for initialization
    void Start() {

        PlayerPrefsManager.SetAlarm(ParseHours(), ParseMinutes() + 10);
        alarmTimeText.text = getTimeAsString(PlayerPrefsManager.GetAlarmHour(), PlayerPrefsManager.GetAlarmMinute());


        secondStarter = ParseSeconds();
        if ((secondsToAlarmSet + secondStarter) > 60)
        {
            alarmTimer = secondsToAlarmSet + secondStarter - 60;
        } else
        {
            alarmTimer = secondsToAlarmSet + secondStarter;
        }

    }

    public void resetAlarm()
    {
        PlayerPrefsManager.ResetAlarm();
        alarmTimeText.text = getTimeAsString(PlayerPrefsManager.GetAlarmHour(), PlayerPrefsManager.GetAlarmMinute());
    }

    private string getTimeAsString(int hour, int minute)
    {
        string tempString;
        string hourString;
        string minuteString;

        if (hour < 10)
        {
            hourString = "0" + hour.ToString();
        } else
        {
            hourString = hour.ToString();
        }

        if (minute < 10)
        {
            minuteString = "0" + minute.ToString();
        }
        else
        {
            minuteString = minute.ToString();
        }

        tempString = hourString + ":" + minuteString;

        return tempString;
    }

    private int ParseSeconds()
    {
        int returnValue;
        int.TryParse(System.DateTime.Now.ToString("ss"), out returnValue);
        return returnValue;
    }

    private int ParseHours()
    {
        int returnValue = 0;
        int.TryParse(System.DateTime.Now.ToString("hh"), out returnValue);
        return returnValue;
    }

    private int ParseMinutes()
    {
        int returnValue = 0;
        int.TryParse(System.DateTime.Now.ToString("mm"), out returnValue);
        return returnValue;
    }



    // Update is called once per frame
    void Update()
    {
        currentTimeText.text = getTimeAsString(ParseHours(), ParseMinutes());

        if(ParseHours() > PlayerPrefsManager.GetAlarmHour())
        {
            alarmText.text = "Alarm Passed!";
        } else
        {
            if (ParseMinutes() > PlayerPrefsManager.GetAlarmMinute())
            {
                alarmText.text = "Alarm Passed!";
            } else
            {
                alarmText.text = "Alarm Not Passed!";
            }
        }
    }
    
}
