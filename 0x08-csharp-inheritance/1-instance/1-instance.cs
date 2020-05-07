using System;
using System.Collections.Generic;

/// <summary>
/// Provides obj type checking.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if an obj is an instance of an Array.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if it is an instance or False.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
