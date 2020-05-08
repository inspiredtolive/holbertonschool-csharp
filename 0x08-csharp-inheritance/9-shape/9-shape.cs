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

    /// <summary>
    /// Computes the area of the Rectangle.
    /// </summary>
    /// <returns>The area.</returns>
    public new int Area()
    {
        return Height * Width;
    }

    /// <summary>
    /// Provides a new string representation of the Rectangle.
    /// </summary>
    /// <returns>The string representation.</returns>
    public override string ToString()
    {
        return String.Format("[{0}] {1} / {2}", this.GetType().Name, Width, Height); 
    }
}

/// <summary>
/// Represents a square.
/// </summary>
class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Gets or sets the size.
    /// </summary>
    /// <value>The value set the size to.</value>
    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Height = value;
            Width = value;
        }
    }
}