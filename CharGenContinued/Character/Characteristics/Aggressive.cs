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
            SetDescription("Acts on impulse, getting through life with violence or threats thereof.");
            SetTraitName("Aggressive");
            string[] examines = {
                "They seem quite easily irritated.",
                "Their fists are clenched and their sleeves lightly torn.",
                "They're scowling back at you.",
                "They seem angry at some of the others."};
            SetTraitExamines(examines);
            string[] hints = {
                "I heard the victim had a lot more wounds than would've been necessary.",
                "I assume whoever was yelling those angry, nasty things was the killer.",
                "I think this may have been a hate crime and not just a random attack.",
                "I think that angry person there did it, but I could be next if they see me pointing."};
            SetTraitHints(hints);
        }
    }
}
