﻿using System;
namespace Roguelike
{
	public class Strong : Trait
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Roguelike.Strong"/> class.
        /// </summary>
        public Strong()
        {
            SetDescription("Intimidatingly muscular, able to carry and swing very heavy objects.");
            SetTraitName("Strong");
            string[] examines = {
                "You can tell they work out.",
                "Their stance is a confident one.",
                "They seem to be exercising a bit to pass the time.",
                "They look like they could crush your skull..."};
            SetTraitExamines(examines);
            string[] hints = {
                "I heard the victim had a lot of broken bones.",
                "I heard someone picked up the body and hid it somewhere else.",
                "I think I caught a glimpse of the killer. They looked pretty big.",
                "Apparently the killer busted down a door. Who's strong enough to do that?"};
            SetTraitHints(hints);
        }
    }
}
