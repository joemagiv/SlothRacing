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

    // Use this for initialization
    void Start () {
        updateText();
	}

    public void increaseSpeed()
    {
        if (availableStatPoints > 0)
        {
            slothSpeed++;
            availableStatPoints--;
        }
        updateText();
    }

    public void decreaseSpeed()
    {
        if (slothSpeed > 0)
        {
            slothSpeed--;
            availableStatPoints++;
        }
        updateText();
    }

    public void increaseStamina()
    {
        if (availableStatPoints > 0)
        {
            slothStamina++;
            availableStatPoints--;
        }
        updateText();
    }

    public void decreaseStamina()
    {
        if (slothStamina > 0)
        {
            slothStamina--;
            availableStatPoints++;
        }
        updateText();
    }

    public void increaseAgility()
    {
        if (availableStatPoints > 0)
        {
            slothAgility++;
            availableStatPoints--;
        }
        updateText();
    }

    public void decreaseAgility()
    {
        if (slothAgility > 0)
        {
            slothAgility--;
            availableStatPoints++;
        }
        updateText();
    }

    public void increaseGrit()
    {
        if (availableStatPoints > 0)
        {
            slothGrit++;
            availableStatPoints--;
        }
        updateText();
    }

    public void decreaseGrit()
    {
        if (slothGrit > 0)
        {
            slothGrit--;
            availableStatPoints++;
        }
        updateText();
    }

    private void updateText()
    {
        availableStatPointsText.text = "Available Points: " + availableStatPoints.ToString();
        slothSpeedText.text = "Speed: " + slothSpeed.ToString();
        slothStaminaText.text = "Stamina: " + slothStamina.ToString();
        slothAgilityText.text = "Agility: " + slothAgility.ToString();
        slothGritText.text = "Grit: " + slothGrit.ToString();
    }

	// Update is called once per frame
	void Update () {
		
	}
}
