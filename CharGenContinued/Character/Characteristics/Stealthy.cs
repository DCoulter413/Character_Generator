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
                "They sometimes stand so still, you could forget they were here.",
                "They're practicing concealing coins in their palms and sleeves.",
                "Looks like they're looking for a way to sneak out of here.",
                "You can't seem to see their eyes."};
            SetTraitExamines(examines);
            string[] hints = {
                "I heard that it didn't look like the victim landed a single hit back on the killer.",
                "I didn't hear anything. I didn't even know there was a murder.",
                "Frustrating that I was nearby during the murder and yet didn't really see anything helpful.",
                "I heard the victim had wounds around their throat and back."};
            SetTraitHints(hints);
        }
    }
}
