using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
  public  class Wizard : MagicUsingCharacter
    {
        private int _spellNumber;
        public Wizard()
        {

        }

        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber)
        {
            SetName(name);
            SetStrenght(strength);
            SetIntelligence(intelligence);
            SetMagicalEnergy(magicalEnergy);
            _spellNumber = spellNumber;
        }

        public int GetSpellNumber()
        {
            return _spellNumber;
        }
        public void SetSpellNumber(int spellNumber)
        {
            _spellNumber = spellNumber;
        }

        public override void Play()
        {
            Console.WriteLine($"Name: { GetName()}\nStrength: { GetStrength()}\nIntelligence: { GetIntelligence()}\nMagical Energy:" +
                $" {GetMagicalEnergy()}\nSpell Number: {_spellNumber}");

        }

    }
}
