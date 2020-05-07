using System;
using System.Collections.Generic;

/// <summary>
/// Provides obj type checking.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if an obj is an int.
    /// </summary>
    /// <param name="obj">The obj to check.</param>
    /// <returns>True if the object is an int or False.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
