using System;
using System.Collections.Generic;

namespace Quest
{
    // An instance of the Adventurer class is an object that will undergo some challenges
    public class Adventurer
    {
        // This is an "immutable" property. It only has a "get".
        // The only place the Name can be set is in the Adventurer constructor
        // Note: the constructor is defined below.
        public string Name { get; set; }

        // This is a mutable property it has a "get" and a "set"
        //  So it can be read and changed by any code in the application
        public int Awesomeness { get; set; }

        // immutable property to the Adventurer class called ColorfulRobe. The type of this property should be Robe.
        public Robe ColorfulRobe { get; }

        public Hat HatType { get; }

        // A constructor to make a new Adventurer object with a given name
        public Adventurer(Robe robe, Hat hat)
        {
            Name = Console.ReadLine();
            ColorfulRobe = robe;
            HatType = hat;
            Awesomeness = 50;
        }

        public string GetDescription()
        {
            //robe colors would not work until creating a string and joinging...unsure why
            string RobeColors = String.Join(", ", ColorfulRobe.Colors);
            return $"{Name} is wearing a {HatType.ShininessDescription} hat and a {RobeColors} robe that is {ColorfulRobe.Length} inches long";
        }

        // This method returns a string that describes the Adventurer's status
        // Note one way to describe what this method does is:
        //   it transforms the Awesomeness integer into a status string
        public string GetAdventurerStatus()
        {
            string status = "okay";
            if (Awesomeness >= 75)
            {
                status = "great";
            }
            else if (Awesomeness < 25 && Awesomeness >= 10)
            {
                status = "not so good";
            }
            else if (Awesomeness < 10 && Awesomeness > 0)
            {
                status = "barely hanging on";
            }
            else if (Awesomeness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Adventurer, {Name}, is {status}";
        }
    }
}
