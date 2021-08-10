using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
   public class MagicUsingCharacter : GameCharacter
    {
        private int _magicalEnergy;
        
        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy) : base (name, strength, intelligence)
        {           
            _magicalEnergy = magicalEnergy;
        }
        
        public int MagicalEnergy
        {
            get { return _magicalEnergy; }
            set { _magicalEnergy = value; }
        }

        public override void Play()
        {
            Console.WriteLine($"Name: {Name}\nStrenght: {Strength}\nIntelligence: {Intelligence}\nMagical Energy: " +
                $"{MagicalEnergy}");
        }

    }
}
