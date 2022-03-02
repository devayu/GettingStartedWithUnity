using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    private int _health;
    private int _power;
    private string _name;

    //** getter and setters for class private vars
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }
    public int Power
    {
        get
        {
            return _power;
        }
        set
        {
            _power = value;
        }
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    public Player() { }
    public Player(int health, int power, string name)
    {
        Health = health;
        Power = power;
        Name = name;
    }
    public void Info()
    {
        Debug.Log(Name);
        Debug.Log("Health" + Health);
        Debug.Log("Power" + Power);
    }
    public virtual void Attack()
    {
        Debug.Log("Attacking");
    }
    // public void setHealth(int health)
    // {
    //     Health = health;
    // }

    // public int getHealth()
    // {
    //     return Health;
    // }
}
