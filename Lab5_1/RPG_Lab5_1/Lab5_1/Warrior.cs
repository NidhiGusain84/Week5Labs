using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
   public class Warrior : GameCharacter
    {
        private string _weaponType;


        public Warrior(string name, int strength, int intellegence, string weaponType) : base(name, strength, intellegence)
        {
            _weaponType = weaponType;
        }


        public string WeaponType
        {
            get { return _weaponType; }
            set { _weaponType = value; }
        }

        
        public override void Play()
        {
            Console.WriteLine($"Name: {Name}\nStrength: {Strength}\nIntelligence: {Intelligence}\nWeapon Type:  {WeaponType}");
        }

    }
}