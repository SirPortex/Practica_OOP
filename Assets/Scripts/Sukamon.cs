using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Sukamon : Character
{

    public Sukamon(string name) : base(name, 1, Resources.Load<Sprite>("Sprites/Ghost")) // construimos padre
    {

    }

    public override float Attack()
    {
        if (health <= 5)
        {
            return damage = 100;
        }
        else
        {
            return damage;
        }
        Debug.Log("Cowboy ataca");

    }

    public override float Heal()
    {
        float restoreHeal;
        Debug.Log("cowboy se cura");
        restoreHeal = damage * 0.3f;
        health += restoreHeal;
        base.Heal();
        return restoreHeal;
    }
}
