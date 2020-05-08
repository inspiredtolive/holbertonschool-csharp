using System;

/// <summary>
/// Provides object type checking.
/// </summary>
class Obj
{
    /// <summary>
    /// Checks if a type is a subclass of another type.
    /// </summary>
    /// <param name="derivedType">The derived type.</param>
    /// <param name="baseType">The base type to check against.</param>
    /// <returns>True if the derived type is a subclass or False.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
