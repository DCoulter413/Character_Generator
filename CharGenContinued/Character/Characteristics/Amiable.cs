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
                "They're surrounded by a small group of people.",
                "When you look at them, they smile weakly.",
                "One of their friends is leaning on their shoulder.",
                "Despite everything, you have to admit they're quite charming."};
            SetTraitExamines(examines);
            string[] hints = {
                "I heard there was evidence of more than two people at the scene.",
                "The murder took place during a party. I'm lucky I wasn't there.",
                "I think I saw a mostly-empty drink next to the victim.",
                "I saw a group walking through here just before the murder."};
            SetTraitHints(hints);
        }
    }
}
