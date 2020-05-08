using System;

/// <summary>
/// Represents a shape.
/// </summary>
class Shape
{
    /// <summary>
    /// Computes the area, not implemented.
    /// </summary>
    /// <returns>The area.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
