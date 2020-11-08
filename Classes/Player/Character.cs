using FirstFantasy.Classes.Equipment;
using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public abstract class Character : IDescribable
    {
        private String name;
        private int level;
        private int experience;
        private Equipment.Weapon weapon;
        private Armor armor;
        

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public Weapon Weapon { get => weapon; set => weapon = value; }
        public Armor Armor { get => armor; set => armor = value; }

        public abstract String Taunt();

        public virtual String ShowCharacter()
        {
            return "Name: "+name+ " Level "+level+ " XP: "+experience;
        }

        public string ShowInformation()
        {
            return "This is a level "+level+ " character";
        }
        public int Attack()
        {
            Random rand = new Random();
            return rand.Next(1, 9) + weapon.Dmg;
        }
    }
}
