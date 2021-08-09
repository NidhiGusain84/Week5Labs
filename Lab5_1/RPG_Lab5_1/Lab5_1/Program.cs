using System;
using System.Collections.Generic;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to World of Dev.Buildcraft!");

            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            Warrior w1 = new Warrior("Tnarg the barbarian", 16, 9 , "Axe");
            Warrior w2 = new Warrior("Kincaid the Fighter", 15, 16, "Longsword");

            Wizard one = new Wizard("Lady Witherell the Wizard", 11, 18, 10, 5);
            Wizard two = new Wizard("Pearl the Magician", 12, 17, 9, 4);
            Wizard three = new Wizard("Draco Malfoy", 15, 21, 10, 7);

            gameCharacters.Add(w1);
            gameCharacters.Add(w2);
            gameCharacters.Add(one);
            gameCharacters.Add(two);
            gameCharacters.Add(three);

            for (int i = 0; i < gameCharacters.Count; i++)
            {
                gameCharacters[i].Play();
                Console.WriteLine();
            }
            

        }
    }
}
