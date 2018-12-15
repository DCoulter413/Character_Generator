using System;
namespace Roguelike
{
    public class Stealthy : Trait
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Roguelike.Stealthy"/> class.
        /// </summary>
        public Stealthy()
        {
            SetDescription("Master of sneaking around, blending in, and sleight of hand.");
            SetTraitName("Stealthy");
            string[] examines = {
                "They stand as still as a piece of furniture.",
                "They seem to be practicing coin tricks.",
                "They look like they want to sneak out of here.",
                "Their face is difficult to see."};
            SetTraitExamines(examines);
            string[] hints = {
                "I heard that it didn't look like the victim landed a single hit back on the killer.",
                "I didn't hear anything. I wouldn't have known there was a murder.",
                "I was nearby during the murder, but I didn't really see anything helpful.",
                "I heard the victim had wounds around their throat and back."};
            SetTraitHints(hints);
        }
    }
}
