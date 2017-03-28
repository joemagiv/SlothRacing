using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {


	const string HIGH_SCORE = "high_score";
	const string CURRENT_SCORE = "current_score";

    const string CURRENT_HOUR = "current_hour";
    const string CURRENT_MINUTE = "current_minute";

    const string ALARM_HOUR = "alarm_hour";
    const string ALARM_MINUTE = "alarm_minute";

    const string SLOTH_SPEED = "sloth_speed";
    const string SLOTH_STAMINA = "sloth_stamina";
    const string SLOTH_AGILITY = "sloth_agility";
    const string SLOTH_GRIT = "sloth_grit";

    const string REMAINING_STATS = "remaining_stats";

    const string ALARM_SET = "alarm_set";

    //Setting the volume

    public static int GetHighScore(){
		return PlayerPrefs.GetInt(HIGH_SCORE);
	}
	
	
	public static void CheckSetHighScore(int playerScore){
		if (playerScore > PlayerPrefs.GetInt(HIGH_SCORE)){
			PlayerPrefs.SetInt(HIGH_SCORE, playerScore);
		}
	}
	
	public static int GetCurrentScore(){
		return PlayerPrefs.GetInt(CURRENT_SCORE);
	}
	
	public static void SetCurrentScore(int playerScore){
		PlayerPrefs.SetInt(CURRENT_SCORE, playerScore);
	}

    public static void SetCurrentTime(int currentHour, int currentMinute)
    {
        PlayerPrefs.SetInt(CURRENT_HOUR, currentHour);
        PlayerPrefs.SetInt(CURRENT_MINUTE, currentMinute);
    }

    public static void SetAlarm(int alarmHour, int alarmMinute)
    {
        if (GetAlarmSet() < 1)
        {
            PlayerPrefs.SetInt(ALARM_HOUR, alarmHour);
            PlayerPrefs.SetInt(ALARM_MINUTE, alarmMinute);
            PlayerPrefs.SetInt(ALARM_SET, 1);
        }

    }

    public static int GetAlarmHour()
    {
        return PlayerPrefs.GetInt(ALARM_HOUR);
    }

    public static int GetAlarmMinute()
    {
        return PlayerPrefs.GetInt(ALARM_MINUTE);
    }

    public static int GetAlarmSet()
    {
        return PlayerPrefs.GetInt(ALARM_SET);
    }

    public static void ResetAlarm()
    {
        PlayerPrefs.SetInt(ALARM_SET, 0);
        PlayerPrefs.SetInt(ALARM_HOUR, 0);
        PlayerPrefs.SetInt(ALARM_MINUTE, 0);
    }

    public static void SetSlothSpeed(int speed)
    {
        PlayerPrefs.SetInt(SLOTH_SPEED, speed);
    }

    public static int GetSlothSpeed()
    {
        return PlayerPrefs.GetInt(SLOTH_SPEED);
    }

    public static void SetSlothStamina(int stamina)
    {
        PlayerPrefs.SetInt(SLOTH_STAMINA, stamina);
    }

    public static int GetSlothStamina()
    {
        return PlayerPrefs.GetInt(SLOTH_STAMINA);
    }

    public static void SetSlothAgility(int agility)
    {
        PlayerPrefs.SetInt(SLOTH_AGILITY, agility);
    }

    public static int GetSlothAgility()
    {
        return PlayerPrefs.GetInt(SLOTH_AGILITY);
    }

    public static void SetSlothGrit(int grit)
    {
        PlayerPrefs.SetInt(SLOTH_GRIT, grit);
    }

    public static int GetSlothGrit()
    {
        return PlayerPrefs.GetInt(SLOTH_GRIT);
    }

    public static void RemainingStats(int stats)
    {
        PlayerPrefs.SetInt(REMAINING_STATS, stats);
    }

    public static int GetRemainingStatst()
    {
        return PlayerPrefs.GetInt(REMAINING_STATS);
    }


}
