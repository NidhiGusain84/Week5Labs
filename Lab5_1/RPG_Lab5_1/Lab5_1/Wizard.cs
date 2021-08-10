using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
  public  class Wizard : MagicUsingCharacter
    {
        private int _spellNumber;
        
        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber)
            : base (name, strength, intelligence, magicalEnergy)
        {            
           _spellNumber = spellNumber;
        }



        public int SpellNumber
        {
            get { return _spellNumber; }
            set { _spellNumber = value; }
        }



        public override void Play()
        {
            Console.WriteLine($"Name: { Name}\nStrength: { Strength}\nIntelligence: { Intelligence}\nMagical Energy:" +
                $" {MagicalEnergy}\nSpell Number: {SpellNumber}");
        }

    }
}
