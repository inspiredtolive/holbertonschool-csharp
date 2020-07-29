using System;
using System.Collections.Generic;

/// <summary>
/// Provides an abstract base class.
/// </summary>
abstract class Base
{
    public string name = "";

    /// <summary>
    /// Gets the string representation of the instance.
    /// </summary>
    /// <returns>The string representation.</returns>
    public override string ToString()
    {
        return String.Format("{0} is a {1}", name, this.GetType().Name);
    }
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// Represents a Door.
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// Sets the name of the Door.
    /// </summary>
    /// <param name="doorName">The name of the door (defaults to "Door").</param>
    public Door(string doorName = "Door")
    {
        this.name = doorName;
    }

    /// <summary>
    /// Prints interaction string.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine(String.Format("You try to open the {0}. It's locked.", this.name));
    }
}

/// <summary>
/// Represents a Decoration.
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    public int durability { get; set; } = 1;
    public bool isQuestItem = false;

    /// <summary>
    /// The decoration constructor.
    /// </summary>
    /// <param name="name">The nameof the Decoration.</param>
    /// <param name="durability">The durability of the Decoration.</param>
    /// <param name="isQuestItem">Whether the Decoration is a quest item.</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interacts with the Decoration.
    /// </summary>
    public void Interact()
    {
        if (this.durability <= 0)
        {
            Console.WriteLine(String.Format("The {0} has been broken.", this.name));
        }
        else if (this.isQuestItem == true)
        {
            Console.WriteLine(String.Format("You look at the {0}. There's a key inside.", this.name));
        }
        else
        {
            Console.WriteLine(String.Format("You look at the {0}. Not much to see here.", this.name));
        }
    }

    /// <summary>
    /// Attempts to break the Decoration.
    /// </summary>
    public void Break()
    {
        if (this.durability <= 0)
        {
            Console.WriteLine(String.Format("The {0} is already broken.", this.name));
            return;
        }
        this.durability--;
        if (this.durability == 0)
        {
            Console.WriteLine(String.Format("You smash the {0}. What a mess.", this.name));
        }
        else
        {
            Console.WriteLine(String.Format("You hit the {0}. It cracks.", this.name));
        }
    }
}

/// <summary>Collectible key.</summary>
class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    /// <summary>The Key constructor.</summary>
    /// <param name="name">The name of the Key.</param>
    /// <param name="isCollected">Whether the Key has been collected.</param>
    public Key(string name="Key", bool isCollected=false) {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>Collects the Key.</summary>
    public void Collect() {
        if (this.isCollected)
            Console.WriteLine("You have already picked up the {0}.", this.name);
        else
            Console.WriteLine("You pick up the {0}.", this.name);
        this.isCollected = true;
    }
}

/// <summary>
/// Represents a Room Object.
/// </summary>
class RoomObjects
{
    /// <summary>Iterates over a list of objects and executes methods based on its interface.</summary>
    /// <param name="roomObjects">The list of objects.</param>
    /// <param name="type">Which type of object to call functions on.</param>
    public static void IterateAction(List<Base> roomObjects, Type type) {
        foreach (Base obj in roomObjects) {
            if (type.IsInstanceOfType(obj)) {
                if (type == typeof(IBreakable))
                    ((IBreakable)obj).Break();
                if (type == typeof(ICollectable))
                    ((ICollectable)obj).Collect();
                if (type == typeof(IInteractive))
                    ((IInteractive)obj).Interact();
            }
        }
    }
}