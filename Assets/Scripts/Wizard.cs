using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Wizard : Character
{
    private float _damageMultiplayer;

    public Wizard(string name, float damageMultiplayer) : base(name, 20, Resources.Load<Sprite>("Sprites/Wizard")) // construimos padre
    {
        _damageMultiplayer = damageMultiplayer;
    }

    public override float Attack()
    {
        Debug.Log("Cowboy ataca");
        return damage * _damageMultiplayer;
    }

    public override float Heal()
    {
        float restoreHeal;
        Debug.Log("cowboy se cura");
        restoreHeal = Random.Range(damage, damage*_damageMultiplayer);
        health += restoreHeal;
        base.Heal();
        return restoreHeal;
    }
}
