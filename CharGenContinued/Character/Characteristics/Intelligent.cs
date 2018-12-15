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
            string[] examines = {
                "Their mind appears to be elsewhere at the moment.",
                "They occasionally glance down at a small book.",
                "They're faintly muttering something you don't understand.",
                "They appear to be as deep in thought as you are."};
            SetTraitExamines(examines);
            string[] hints = {
                "I saw a smashed chemistry bottle at the crime scene.",
                "There's some weird rumors that the killer had tentacles.",
                "I heard the victim looked like they had claw marks on them.",
                "There was some weird purple goop around the crime scene."};
            SetTraitHints(hints);
        }
    }
}
