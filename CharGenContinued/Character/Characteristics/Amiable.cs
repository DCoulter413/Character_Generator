using System;
namespace Roguelike
{
    public class Amiable : Trait
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Roguelike.Amiable"/> class.
        /// </summary>
        public Amiable()
        {
            SetDescription("Naturally likeable, with little difficulty building vast networks of friends.");
            SetTraitName("Amiable");
            string[] examines = {
                "They're discussing the case with a small crowd.",
                "They're smiling weakly.",
                "They're comforting a friend.",
                "Their charisma draws you in."};
            SetTraitExamines(examines);
            string[] hints = {
                "I heard there were more than two sets of footprints at the scene.",
                "I think the murder took place just outside from a party.",
                "I heard there was a half-full drink next to the victim.",
                "I saw a group walking here when the murder happened."};
            SetTraitHints(hints);
        }
    }
}
