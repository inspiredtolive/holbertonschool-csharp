using System;

/// <summary>
/// Represents a queue.
/// </summary>
/// <typeparam name="T">The type of queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Gets the queue's type.
    /// </summary>
    /// <returns>The type of the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}