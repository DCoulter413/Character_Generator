using System;
namespace Roguelike
{
    public class Aggressive : Trait
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Roguelike.Aggressive"/> class.
        /// </summary>
        public Aggressive()
        {
            SetDescription("Acts on impulse, often with violence or threats thereof.");
            SetTraitName("Aggressive");
        }
    }
}
