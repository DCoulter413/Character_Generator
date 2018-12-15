using System;
namespace Roguelike
{
    class Suspect : Character
    {
        public String[] Examine;
        public String Hint;
        public String[] Personality;
        public Random r;

        public Suspect() {
            Name = NameGenerator();
            InitialiseTraits();
            InitialiseCharacterBaseAttributes(Name);
            InitialiseCharacterExamines();
        }

        void InitialiseCharacterExamines(){
            //for each personality trait draw a random flavor text from the trait class
            for (int i = 0; i < _Traits.Count - 1; i++) {
                Personality[i] = _Traits[i].TraitName;
                Examine[i] = (_Traits[i].TraitExamines[r.Next(0, _Traits[i].TraitExamines.Count)]);
                Console.WriteLine(Examine[i]);
            }
        }
    }
}
