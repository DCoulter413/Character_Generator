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
                "They're scowling at you and the others.",
                "They're muttering angrily about the other people here."};
            SetTraitExamines(examines);
            string[] hints = {
                "I heard the victim had a lot more wounds than necessary.",
                "I assume whoever was yelling those angry, nasty things was the killer.",
                "I think this may have been a hate crime and not just a random attack.",
                "I suspect that angry person over there, but I don't want them to see me pointing."};
            SetTraitHints(hints);
        }
    }
}
