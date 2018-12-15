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
                "They're talking with a small crowd.",
                "Upon seeing you, they smile weakly.",
                "They seem to be comforting a friend.",
                "Despite everything, they're quite charming."};
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
