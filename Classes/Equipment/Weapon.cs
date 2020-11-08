using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public abstract class Weapon : IDescribable
    {
        private int dmg;

        public int Dmg { get => dmg; set => dmg = value; }

        public string ShowInformation()
        {
            return "This is a weapon";
        }

    }
}
