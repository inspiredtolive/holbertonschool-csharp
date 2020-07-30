using System;

///<summary>Represents modifiers.</summary>
enum Modifier
{
    Weak, Base, Strong
}

/// <summary>Calculates modifiers.</summary>
delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>Provides current HP arguments.</summary>
class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;

    /// <summary>The CurrentHPArgs constructor.</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

///<summary>Represents a Player.</summary>
class Player
{
    string name;
    float maxHp;
    float hp;
    string status;
    EventHandler<CurrentHPArgs> HPCheck;

    ///<summary>The Player contructor.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.name = name;
        this.hp = this.maxHp;
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    ///<summary>Print health of the Player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
    }

    ///<summary>Damages the Player.</summary>
    public void TakeDamage(float damage)
      {
        if (damage < 0f)
            damage = 0f;
        Console.WriteLine($"{this.name} takes {damage} damage!");
        float newHp = this.hp - damage;
        this.ValidateHP(newHp);
    }

    ///<summary>Heals the Player.</summary>
    public void HealDamage(float heal)
	{
		float newHp = this.hp;
		if (heal < 0f)
			heal = 0f;
		Console.WriteLine("{0} heals {1} HP!", this.name, heal);
		newHp += heal;
		ValidateHP(newHp);
	}

    ///<summary>Sets the Player's hp.</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else 
            this.hp = newHp;
        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    ///<summary>Applys modifiers.</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue * 0.5f;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
    }

    ///<summary>Checks the Player's status.</summary>
        private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = $"{this.name} is in perfect health!";
        else if (e.currentHp >= (this.maxHp / 2))
            this.status = $"{this.name} is doing well!";
        else if (e.currentHp >= (this.maxHp / 4))
            this.status = $"{this.name} isn't doing too great...";
        else if (e.currentHp > 0)
            this.status = $"{this.name} needs help!";
        else
            this.status = $"{this.name} is knocked out!";
        Console.WriteLine(this.status);
    }
}