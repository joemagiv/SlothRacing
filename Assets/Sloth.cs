using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sloth  {

    public int speed;
    public int grit;
    public int stamina;
    public int agility;

    public void newValues()
    {
        speed = Mathf.RoundToInt(Random.Range(1, 5));
        grit = Mathf.RoundToInt(Random.Range(1, 5));
        stamina = Mathf.RoundToInt(Random.Range(1, 5));
        agility = Mathf.RoundToInt(Random.Range(1, 5));

    }
}
