using System;
namespace Roguelike
{
    class Suspect : Character
    {
        public String[] Examine = {"test0", "test1"};
        public String Hint = "";
        public int ID = 0;

        //public String[] Personality = {"0test", "1test"};
        //I don't think this actually does anything yet so I commented it out until I find a purpose
        static Random Rnd = new Random();

        public Suspect() {
            Name = NameGenerator();
            InitialiseTraits();
            InitialiseCharacterBaseAttributes(Name);
            InitialiseCharacterExamines();
        }

        void InitialiseCharacterExamines(){
            //for each personality trait draw a random flavor text from the trait class
            for (int i = 0; i < _Traits.Count; i++) {
                //Personality[i] = _Traits[i].TraitName;
                //also unused

                Examine[i] = (_Traits[i].TraitExamines[Rnd.Next(0, _Traits[i].TraitExamines.Count)]);
                //Console.WriteLine(Examine[i]);
            }
        }
    }
}
