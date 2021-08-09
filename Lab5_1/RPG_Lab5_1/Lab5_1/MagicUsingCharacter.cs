using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
   public class MagicUsingCharacter : GameCharacter
    {
        private int _magicalEnergy;

        public MagicUsingCharacter()
        {

        }
        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy)
        {
            SetName(name);
            SetStrenght(strength);
            SetIntelligence(intelligence);
            _magicalEnergy = magicalEnergy;
        }

        public int GetMagicalEnergy()
        {
            return _magicalEnergy;
        }

        public void SetMagicalEnergy(int magicalEnergy)
        {
            _magicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"Name: {GetName()}\nStrenght: {GetStrength()}\nIntelligence: {GetIntelligence()}\nMagical Energy: " +
                $"{GetMagicalEnergy()}");
        }

    }
}
