using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
   public class Warrior : GameCharacter
    {
        private string _weaponType;

        public Warrior()
        {

        }

        public Warrior(string name, int strength, int intellegence, string weaponType)
        {
            SetName(name);
            SetStrenght(strength);
            SetIntelligence(intellegence);
            _weaponType = weaponType;
        }

        public  string GetWeaponType()
        {
            return _weaponType;
        }

        public void SetWeaponType(string weaponType)
        {
            _weaponType = weaponType;
        }

        public override void Play()
        {
            Console.WriteLine($"Name: {GetName()}\nStrength: {GetStrength()}\nIntelligence: {GetIntelligence()}\nWeapon Type:  {_weaponType}");
        }

    }
}
