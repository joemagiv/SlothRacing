using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public int availableStatPoints;

    public int slothSpeed;
    public int slothStamina;
    public int slothAgility;
    public int slothGrit;

    public Text availableStatPointsText;

    public Text slothSpeedText;
    public Text slothStaminaText;
    public Text slothAgilityText;
    public Text slothGritText;

    public Text raceOverText;

    private Sloth enemySloth01;
    private Sloth enemySloth02;
    private Sloth enemySloth03;

    public Slider yourSlothSlider;
    public Slider enemySloth01Slider;
    public Slider enemySloth02Slider;
    public Slider enemySloth03Slider;

    public bool raceStarted;

    public bool raceOver;

    // Use this for initialization
    void Start() {
        

        enemySloth01 = new Sloth();
        enemySloth01.newValues();
        enemySloth02 = new Sloth();
        enemySloth02.newValues();
        enemySloth03 = new Sloth();
        enemySloth03.newValues();

        slothSpeed = PlayerPrefsManager.GetSlothSpeed();
        slothAgility = PlayerPrefsManager.GetSlothAgility();
        slothStamina = PlayerPrefsManager.GetSlothStamina();
        slothGrit = PlayerPrefsManager.GetSlothGrit();

        updateText();

    }

    public void increaseSpeed()
    {
        if (availableStatPoints > 0)
        {
            slothSpeed++;
            availableStatPoints--;
            PlayerPrefsManager.SetSlothSpeed(slothSpeed);
        }
        updateText();
    }

    public void decreaseSpeed()
    {
        if (slothSpeed > 0)
        {
            slothSpeed--;
            availableStatPoints++;
            PlayerPrefsManager.SetSlothSpeed(slothSpeed);

        }
        updateText();
    }

    public void increaseStamina()
    {
        if (availableStatPoints > 0)
        {
            slothStamina++;
            availableStatPoints--;
            PlayerPrefsManager.SetSlothStamina(slothStamina);

        }
        updateText();
    }

    public void decreaseStamina()
    {
        if (slothStamina > 0)
        {
            slothStamina--;
            availableStatPoints++;
            PlayerPrefsManager.SetSlothStamina(slothStamina);

        }
        updateText();
    }

    public void increaseAgility()
    {
        if (availableStatPoints > 0)
        {
            slothAgility++;
            availableStatPoints--;
            PlayerPrefsManager.SetSlothAgility(slothAgility);

        }
        updateText();
    }

    public void decreaseAgility()
    {
        if (slothAgility > 0)
        {
            slothAgility--;
            availableStatPoints++;
            PlayerPrefsManager.SetSlothAgility(slothAgility);

        }
        updateText();
    }

    public void increaseGrit()
    {
        if (availableStatPoints > 0)
        {
            slothGrit++;
            availableStatPoints--;
            PlayerPrefsManager.SetSlothGrit(slothGrit);

        }
        updateText();
    }

    public void decreaseGrit()
    {
        if (slothGrit > 0)
        {
            slothGrit--;
            availableStatPoints++;
            PlayerPrefsManager.SetSlothGrit(slothGrit);

        }
        updateText();
    }

    public float speedOffset;

    public float calculateSpeed(int speed, int grit, int stamina, int agility, float position)
    {
        float returnValue = 0;
        if (position < 0.25)
        {
            returnValue += speed * speedOffset;
        }
        if (position > 0.25 && position < 0.50)
        {
            returnValue += grit * speedOffset;
        }
        if (position > 0.50 && position < 0.75)
        {
            returnValue += agility * speedOffset;
        }
        if (position > 0.75)
        {
            returnValue += stamina * speedOffset;
        }

        return returnValue;

     }

    private void updateText()
    {
        availableStatPointsText.text = "Available Points: " + availableStatPoints.ToString();
        slothSpeedText.text = "Speed: " + slothSpeed.ToString();
        slothStaminaText.text = "Stamina: " + slothStamina.ToString();
        slothAgilityText.text = "Agility: " + slothAgility.ToString();
        slothGritText.text = "Grit: " + slothGrit.ToString();
    }

    public void startRace()
    {
        raceStarted = true;
    }

	// Update is called once per frame
	void Update () {
        if (raceStarted)
        {
            yourSlothSlider.value += calculateSpeed(slothSpeed, slothGrit, slothStamina, slothAgility, yourSlothSlider.value);
            enemySloth01Slider.value += calculateSpeed(enemySloth01.speed, enemySloth01.grit, enemySloth01.stamina, enemySloth01.agility, enemySloth01Slider.value);
            enemySloth02Slider.value += calculateSpeed(enemySloth02.speed, enemySloth02.grit, enemySloth02.stamina, enemySloth02.agility, enemySloth02Slider.value);
            enemySloth03Slider.value += calculateSpeed(enemySloth03.speed, enemySloth03.grit, enemySloth03.stamina, enemySloth03.agility, enemySloth03Slider.value);
        }

        if (!raceOver)
        {
            if(yourSlothSlider.value >= 1.0)
            {
                raceOverText.text = "Your Sloth Won!";
                raceOver = true;
                raceStarted = false;
            }
            if (enemySloth01Slider.value >= 1.0)
            {
                raceOverText.text = "Enemy Sloth 01 Won!";
                raceOver = true;
                raceStarted = false;
            }
            if (enemySloth02Slider.value >= 1.0)
            {
                raceOverText.text = "Enemy Sloth 02 Won!";
                raceOver = true;
                raceStarted = false;
            }
            if (enemySloth03Slider.value >= 1.0)
            {
                raceOverText.text = "Enemy Sloth 03 Won!";
                raceOver = true;
                raceStarted = false;
            }
        }
	}
}
