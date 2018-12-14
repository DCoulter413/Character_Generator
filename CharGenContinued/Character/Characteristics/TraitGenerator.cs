using System;
namespace Roguelike
{
	public class TraitGenerator :  RandomList<Trait>
    {
        private Trait[] _allTraits;
        private int _numberOfTraits;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Roguelike.TraitGenerator"/> class.
        /// </summary>

        public TraitGenerator()
        {
            _allTraits = new Trait[] { new Strong(), new Intelligent(), new Amiable(), new Stealthy(), new Aggressive() };
            this.AddAll(_allTraits);

            _numberOfTraits = 2;
        }

        /// <summary>
        /// Generate this instance.
        /// </summary>
        /// <returns>The generate.</returns>

        public RandomList<Trait> Generate () {
            return this.RollList(_numberOfTraits + 1);
        }
    }
}
