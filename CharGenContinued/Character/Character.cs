using System;
namespace Roguelike
{
    public class Character
    {
        public String Name;
        public RandomList<Trait> _Traits;
        public static Random Rnd = new Random();
        public int Age;
        public int Sanity;
        RandomList<String> prefixes = new RandomList<String> { "Car", "Har", "Lar", "Mar", "Dan", "Max", "Fin", "La", "Hen", "Egg", "Oli", "Stri" };
        RandomList<String> suffixes = new RandomList<String> { "cus", "ley", "son", "ton", "bury", "ver", "londe", "mas", "ine", "lette", "bert", "der" };

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Roguelike.Character"/> class if name is given.
        /// </summary>
        public Character(String name)
        {
            InitialiseTraits();
            InitialiseCharacterBaseAttributes(name);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Roguelike.Character"/> class if name is not given.
        /// </summary>
        public Character() {
            String name = NameGenerator();
            InitialiseTraits();
            InitialiseCharacterBaseAttributes(name);
        }

        /// <summary>
        /// Generates names
        /// </summary>
        /// <returns>A name</returns>
        public String NameGenerator() { 
            return prefixes.Roll() + suffixes.Roll();
        }

        /// <summary>
        /// Initialises the Traits.
        /// </summary>
        public void InitialiseTraits () {
            TraitGenerator TraitGenerator = new TraitGenerator();
            _Traits = TraitGenerator.Generate();
        }

        /// <summary>
        /// Initialises the character base attributes.
        /// </summary>
        /// <param name="name">Name.</param>
        public void InitialiseCharacterBaseAttributes(String name) {
            Name = name;
            Age = Rnd.Next(62) + 18;
            Sanity = 100;
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:Roguelike.Character"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:Roguelike.Character"/>.</returns>
        public override string ToString()
        {
            if (Age < 30)
            {
                return "Your name is " + Name + ". You woke up for the first time only " + Age + " years ago.\n" +
                    "You have a youthful spirit and vividly remember your most formative experiences.\n" +
                    "You have the following Traits:\n" + 
                    _Traits;
            }
            else if (Age < 60)
            {
                return "Your name is " + Name + ". You woke up for the first time about " + Age + " years ago.\n" +
                    "You're not as young as you once were, but you're wise enough to know that's okay.\n" +
                    "You have the following Traits:\n" +
                    _Traits;
            }
            else {
                return "Your name is " + Name + ". You woke up for the first time, what was it, " + Age + " years ago?\n" +
                    "You've led a long life, but you still remember most of your skills.\n" +
                    "You have the following Traits:\n" +
                    _Traits;
            }

        }

    }
}
