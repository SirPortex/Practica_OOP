using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Cowboy : Character
{

    public Cowboy(string name) : base(name, 15, Resources.Load<Sprite>("Sprites/Cowboy")) // construimos padre
    {

    }

    public override float Attack()
    {
        Debug.Log("Cowboy ataca");
        return Random.Range(damage, damage * 1.7f);
    }

    public override float Heal()
    {
        Debug.Log("cowboy se cura");
        health += 10;
        base.Heal();
        return 10;
    }
}