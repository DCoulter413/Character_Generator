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
            SetDescription("Has the brainpower and curiosity to solve complex problems.");
            SetTraitName("Intelligent");
            string[] examines = {
                "Their mind appears to be elsewhere at the moment.",
                "They occasionally glance down at a small, old-looking book.",
                "They're faintly muttering something you don't understand.",
                "They appear to be as deep in thought as you are."};
            SetTraitExamines(examines);
            string[] hints = {
                "I saw a smashed chemistry beaker near the crime scene.",
                "There's some weird rumors that the killer had... tentacles?",
                "There were some strange runes drawn near the crime scene.",
                "I heard there was some weird purple goop around the body."};
            SetTraitHints(hints);
        }
    }
}
