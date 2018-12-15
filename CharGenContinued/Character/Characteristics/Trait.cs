using System;
namespace Roguelike
{
    public class Trait
    {
        public String Description;
        public String TraitName;
        RandomList<String> TraitExamines;
        RandomList<String> TraitHints;
        RandomList<String> TraitAlibis;

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

        public void SetTraitAlibis(string[] alibis) {
            TraitAlibis.AddRange(alibis);
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
