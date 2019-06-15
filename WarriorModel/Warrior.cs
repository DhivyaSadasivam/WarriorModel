using System;

namespace WarriorModel
{
    public class Warrior
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public override string ToString()
        {
            return Name + " saving the world with " + Weapon;
        }
        public string Check { get; set; }
    }
}
