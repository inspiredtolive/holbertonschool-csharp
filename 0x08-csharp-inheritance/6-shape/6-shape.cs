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

/// <summary>
/// Represents a Rectangle.
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    /// <value>The value to set the width to.</value>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    /// <value>The value to set the height to.</value>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }
}
