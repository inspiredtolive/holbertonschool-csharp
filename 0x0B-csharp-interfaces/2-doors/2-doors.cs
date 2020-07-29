using System;

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