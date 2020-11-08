using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Player;
using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFantasy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Character myCharacter;
        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            // String option = CboxCharacter.Text;
            /*
            List<IDescribable> objectList = new List<IDescribable>();
            objectList.Add(new Axe());
            objectList.Add(new Potion());
            objectList.Add(new Wizard { Level = 10 });

            IDescribable i = new Classes.Player.Ranger();
            */

            TxtOutput.Text = "";
            /*
            foreach (IDescribable d in objectList)
            {
                TxtOutput.Text += d.ShowInformation()+"\n";
            }

            */


            switch (CboxCharacter.SelectedIndex)
            {
                case 1:
                    myCharacter = new Warrior();
                    break;

                case 2:
                    myCharacter = new Ranger();
                    break;

                case 3:
                    myCharacter = new Berserker();
                    break;

                case 4:
                    myCharacter = new Wizard();
                    break;

                default:
                    myCharacter = null;
                    MessageBox.Show("You MUST select a type");
                    break;

            }
            switch (CboxWeapon.SelectedIndex)
            {
                case 1:
                    myCharacter.Weapon = new Axe();
                    break;

                case 2:
                    myCharacter.Weapon = new Bow();
                    break;

                case 3:
                    myCharacter.Weapon = new Hammer();
                    break;

                case 4:
                    myCharacter.Weapon = new Wand();
                    break;

                default:
                    
                    MessageBox.Show("You MUST select a weapon");
                    break;
            
            }
            switch (CboxArmor.SelectedIndex)
            {
                case 1:
                    myCharacter.Armor = new Angelical_Armor();
                    break;

                case 2:
                    myCharacter.Armor = new Demonic_Armor();
                    break;

                case 3:
                    myCharacter.Armor = new Leaf_Armor();
                    break;

                case 4:
                    myCharacter.Armor = new Steel_Armor();
                    break;

                default:

                    MessageBox.Show("You MUST select a weapon");
                    break;
                    TxtOutput.Text = $"Name: {txtName.Text} \nClass: {CboxCharacter.Text} \nWeapon: {CboxWeapon.Text} \nArmor:{CboxArmor.Text}";
            BtnCreate.IsEnabled = false;
            btnInventory.IsEnabled = true;

        }

        private void btnAttack_Click(object sender, RoutedEventArgs e)
        {
            if (myCharacter != null)
            {

                txtAttackAlert.Text = $"{txtName.Text} Causaste {myCharacter.Attack()} de daño con tú {CboxWeapon.Text}";

            }
            
        }

        private void btnInventory_Click(object sender, RoutedEventArgs e)
        {

            Window inv = new Inventario();
            inv.Show();

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            btnInventory.IsEnabled = false;
        }

    }
}
