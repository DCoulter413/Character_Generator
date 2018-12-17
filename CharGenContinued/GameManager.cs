using System;

namespace Roguelike
{
    public class GameManager
    {
        //put some arrays and whatnot for storing game information here
        private RandomList<Suspect> SuspectObjectList;
        private int KillerID = -1;
        private int PlayerLocation = -2;

        //function for initializing the case

        private void InitializeCase()
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
                        break;
                    default:
                        SuspectObjectList[h].Hint = "Placeholder. The killer is " + SuspectObjectList[KillerID].Name + ".";
                        break;
                }
            }

        }

    //function for the main menu loop

    //function for talking to someone

    //function for accusations

}
