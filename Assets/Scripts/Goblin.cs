using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Goblin : Character
{

    public Goblin(string name) : base(name, 10, Resources.Load<Sprite>("Sprites/Goblin")) // construimos padre
    {

    }

    public override float Attack()
    {
        if (health <= 20)
        {
            return damage * 3;
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
        restoreHeal = damage * 0.5f;
        health += restoreHeal;
        base.Heal();
        return restoreHeal;
    }
}
