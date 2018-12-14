using System;
namespace Roguelike
{
    public class Intelligent : Trait
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Roguelike.Intelligent"/> class.
        /// </summary>
        public Intelligent()
        {
            SetDescription("Has the brain power to understand and solve complex problems.");
            SetTraitName("Intelligent");
        }
    }
}
