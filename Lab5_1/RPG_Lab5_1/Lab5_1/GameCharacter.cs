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
        
        public GameCharacter(string name, int strength, int intelligence)
        {
            _name = name;
            _strength = strength;
            _intelligence = intelligence;
        }
      
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }
       

        public int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }        
        
        public virtual void Play()
        {
            Console.WriteLine($"Name of the Character: {Name}\nStrength: {Strength}\nIntelligence: {Intelligence}");
        }

    }
}
