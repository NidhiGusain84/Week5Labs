using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
  public  class GameCharacter
    {
        private string _name;
        private int _strength;
        private int _intelligence;

        public GameCharacter()
        {

        }
        public GameCharacter(string name, int strength, int intelligence)
        {
            _name = name;
            _strength = strength;
            _intelligence = intelligence;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        
        public void SetStrenght(int strength)
        {
            _strength = strength;
        }

        public int GetStrength()
        {
            return _strength;
        }

        public void SetIntelligence (int intelligence)
        {
            _intelligence = intelligence;
        }

        public int GetIntelligence()
        {
            return _intelligence;
        }

        public virtual void Play()
        {
            Console.WriteLine($"Name of the Character: {_name}\nStrength: {_strength}\nIntelligence: { _intelligence}");
        }

    }
}
