using System;

/// <summary>
/// Represents a queue.
/// </summary>
/// <typeparam name="T">The type of queue.</typeparam>
public class Queue<T>
{
    private Node head = null;
    private Node tail = null;
    private int count = 0;
    
    /// <summary>
    /// Gets the queue's type.
    /// </summary>
    /// <returns>The type of the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Gets the number of nodes in the queue.
    /// </summary>
    /// <returns>The number of nodes.</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Creates and adds a node to the end of the queue.
    /// </summary>
    /// <param name="value">The value of the new node.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (count == 0)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    /// <summary>
    /// Removes the first node in the queue.
    /// </summary>
    /// <returns>The value of the removed node.</returns>
    public T Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T tmp = head.value;
            head = head.next;
            count--;
            return tmp;
        }
    }    

    /// <summary>
    /// Represents a node.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The value of the node.
        /// </summary>
        public T value = default(T);
        /// <summary>
        /// The next node in the queue.
        /// </summary>
        public Node next = null;

        /// <summary>
        /// The Node constructor to set initial values.
        /// </summary>
        /// <param name="nodeValue">The value the node should hold.</param>
        public Node(T nodeValue)
        {
            value = nodeValue;
        }
    }
}