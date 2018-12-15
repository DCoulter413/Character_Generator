using System;
namespace Roguelike
{
    public class Trait
    {
        public String Description;
        public String TraitName;
        public RandomList<String> TraitExamines = new RandomList<string>();
        public RandomList<String> TraitHints = new RandomList<string>();
        public RandomList<String> TraitAlibis = new RandomList<string>();

        /// <summary>
        /// Sets the description.
        /// </summary>
        /// <param name="description">Description.</param>

        public void SetDescription(String description) {
            Description = description;
        }

        public void SetTraitName(String name) {
            TraitName = name;
        }

        public void SetTraitExamines(string[] examines) {
            TraitExamines.AddRange(examines);
        }

        public void SetTraitHints(string[] hints) {
            TraitHints.AddRange(hints);
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:Roguelike.Trait"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:Roguelike.Trait"/>.</returns>

        public override string ToString()
        {
            return TraitName.ToUpper() + ": " + Description;
        }
    }
}
