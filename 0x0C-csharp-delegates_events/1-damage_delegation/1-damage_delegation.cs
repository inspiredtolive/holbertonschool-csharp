﻿using System;

///<summary>Represents a Player.</summary>
class Player
{
    string name;
    float maxHp;
    float hp;

    ///<summary>The Player contructor.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.hp = this.maxHp;
    }

    ///<summary>Print health of the Player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
    }

    ///<summary>Damages the Player.</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            Console.WriteLine(this.name + " takes 0 damage!");
        else
            Console.WriteLine(this.name + " takes " + damage + " damage!");
    }

    ///<summary>Heals the Player.</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            Console.WriteLine(this.name + " heals 0 HP!");
        else
            Console.WriteLine(this.name + " heals " + heal + " HP!");
    }
}