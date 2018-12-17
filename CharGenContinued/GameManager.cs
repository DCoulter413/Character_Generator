using System;

namespace Roguelike
{
    public class GameManager
    {
        //put some arrays and whatnot for storing game information here
        static private RandomList<Suspect> SuspectObjectList = new RandomList<Suspect>();
        private int KillerID = -1;
        private int PlayerLocation = -2;

        //function for initializing the case

        public GameManager()
        {
            //Decide which ID number the killer will have.
            Random WhoDunIt = new Random();
            KillerID = WhoDunIt.Next(0, 10);

            for (int s = 0; s < 10; s++)
            {
                //Generate the ten suspects, assign their IDs, and put them in storage.
                Suspect latestSuspect = new Suspect { ID = s };
                SuspectObjectList.Add(latestSuspect);
            }

            for (int h = 0; h < 10; h++)
            {
                //Generate hints based on what kind of suspect we generated in the previous loop
                //There's probably a way to do this more efficiently
                switch (SuspectObjectList[h].ID == KillerID)
                {
                    case true:
                        SuspectObjectList[h].Hint = "Placeholder. I'm the killer!";
                        SuspectObjectList[h].Sanity -= WhoDunIt.Next(50);
                        break;
                    default:
                        SuspectObjectList[h].Hint = "Placeholder. The killer is " + SuspectObjectList[KillerID].Name + ".";
                        SuspectObjectList[h].Sanity -= WhoDunIt.Next(50);

                        break;
                }
            }

            for (int p = 0; p < 10; p++)
            {
                Console.WriteLine("#" + SuspectObjectList[p].ID + ": " + SuspectObjectList[p].Name);
                Console.WriteLine(SuspectObjectList[p].Hint);
                Console.WriteLine(SuspectObjectList[p].Examine[0]);
                Console.WriteLine(SuspectObjectList[p].Examine[1]);
                Console.WriteLine("They're " + SuspectObjectList[p].Age + " years old.");
                Console.WriteLine("Their sanity is at " + SuspectObjectList[p].Sanity + "%.");
            }

        }

        //function for the main menu loop

        //function for talking to someone

        //function for accusations
    }
}
