using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Armor
    {

        int resistance;
        int health;
        int durability;
        int stealth;

        public int Resistance { get => resistance; set => resistance = value; }
        public int Health { get => health; set => health = value; }
        public int Durability { get => durability; set => durability = value; }
        public int Stealth { get => stealth; set => stealth = value; }

        public string ArmorStadistics()
        {
            return $"Resistencia:{resistance} Healt:{health} Durability:{durability} Stealth:{stealth} ";
        }
    }
}
