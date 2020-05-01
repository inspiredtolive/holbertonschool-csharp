using System;

namespace Enemies
{
    /// <summary>
    /// Represents a Zombie.
    /// </summary>
    class Zombie 
    {
        public int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        /// <param name="value">The Zombie's health value.</param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
    }
}
