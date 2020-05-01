using System;

namespace Enemies
{
    /// <summary>
    /// Represents a Zombie.
    /// </summary>
    class Zombie 
    {
        int health;
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            health = 0;
            Name = "(No name)";
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
            Name = "(No name)";
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
