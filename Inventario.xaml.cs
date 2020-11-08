using FirstFantasy.Classes.Equipment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;


namespace FirstFantasy
{
    /// <summary>
    /// Lógica de interacción para Inventario.xaml
    /// </summary>
    public partial class Inventario : Window
    {
        public Inventario()
        {
            InitializeComponent();
            Things Steel_Armor = new Things();
            Things OrniTunic = new Things();
            Things TunicOfMasters = new Things();
            Things HealtPotion = new Things();

            Steel_Armor SA = new Steel_Armor();
            TunicOfMasters TM = new TunicOfMasters();
            OrniTunic OT = new OrniTunic();
            HealtPotion HP = new HealtPotion();


            OrniTunic.itemName = $"{OT.Name}";
            OrniTunic.itemDescription = $"Durability = {OT.Durability} , Resistance = {OT.Resistance} , Health = {OT.Health}";

            Steel_Armor.itemName = $"{SA.Name}";
            Steel_Armor.itemDescription = $"Durability = {SA.Durability} , Resistance = {SA.Resistance} , Health = {SA.Health}";

            HealtPotion.itemName = $"{HP.Name}";
            HealtPotion.itemDescription = $" This potion will heal you '{HP.Health}' life";

            TunicOfMasters.itemName = $"{TM.Name}";
            TunicOfMasters.itemDescription = $"Durability = {TM.Durability} , Resistance = {TM.Resistance} , Healt = {TM.Health} , Intelligence = {TM.Extra}";

            DataElGrid.Items.Add(OrniTunic);
            DataElGrid.Items.Add(Steel_Armor);
            DataElGrid.Items.Add(TunicOfMasters);
            DataElGrid.Items.Add(HealtPotion);

        }
        public class Things
        {
            public string itemName { get; set; }
            public string itemDescription { get; set; }
        }
        public class Armor
        {
            string name;
            int durability;
            int resistance;
            int health;
            int extra;


            public int Durability { get => durability; set => durability = value; }
            public int Resistance { get => resistance; set => resistance = value; }
            public int Health { get => health; set => health = value; }
            public string Name { get => name; set => name = value; }
            public int Extra { get => extra; set => extra = value; }

        }
        public class Steel_Armor : Armor
        {
            public Steel_Armor()
            {
                Name = "Steel Armor";
                Durability = 10;
                Resistance = 4;
                Health = 4;
            }

        }
        public class TunicOfMasters : Armor
        {
            public TunicOfMasters()
            {
                Name = "Tunic Of Masters";
                Durability = 35;
                Resistance = 40;
                Health = 42;
                Extra = 32;

            }
        }
        public class OrniTunic : Armor
        {
            public OrniTunic()
            {
                Name = "Tunic of Orni";
                Durability = 30;
                Resistance = 35;
                Health = 10;

            }
        }
        public class HealtPotion : Armor
        {
            public HealtPotion()
            {
                Name = "Large Healt Potion";
                Health = 180;

            }
        }
    } 
}
