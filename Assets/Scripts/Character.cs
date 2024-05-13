using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    private string _name;
    public float health = 100f;
    protected float damage;
    private Sprite _sprite;

    public Character()
    {

    }

    public Character(string name, float damage, Sprite sprite)
    {

        this._name = name;
        this.damage = damage;
        _sprite = sprite;
    }

    public Sprite GetSprite() { return _sprite; }

    public float GetDamage()
    {
        return damage;
    }

    public string GetName() { return _name; }

    public abstract float Attack();

    public virtual float Heal()
    {
        Debug.Log("Character se cura");
        //if(health > 100)
        //{
        //    return 100;
        //}
        //else if(health < 0)
        //{
        //    return 0;
        //}
        //else
        //{
        //    return health;
        //}
        health = Mathf.Clamp(health, 0, 100);
        return health;
    }
}