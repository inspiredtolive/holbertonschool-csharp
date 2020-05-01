using System;

namespace Enemies
{
    /// <summary>
    /// Represents a Zombie.
    /// </summary>
    class Zombie 
    {
        int health;

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

        /// <summary>
        /// Gets the health of the zombie.
        /// </summary>
        /// <returns>The health of the zombie.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
