using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpg
{
    public partial class CharacterCreation : Form
    {
        public enum Race
        {
            Human,
            Elf,
            Dwarf
        }

        public enum WeaponSelect
        {
            Sword,
            Dagger,
            Mace
        }
        

        public CharacterCreation()
        {
            InitializeComponent();
        }

        private WeaponSelect MakeWeapon()
        {
            Array Selection = Enum.GetValues(typeof(WeaponSelect));
            Random random = new Random();
            WeaponSelect weapon = (WeaponSelect)Selection.GetValue(random.Next(Selection.Length));
            return weapon;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CharRace.Text == "Human")
            {
                CharHP.Text = Convert.ToString(15);
            }
            else if (CharRace.Text == "Elf")
            {
                CharHP.Text = Convert.ToString(13);
            }
            else if (CharRace.Text == "Dwarf")
            {
                CharHP.Text = Convert.ToString(18);
            }
        }

        private void CharacterCreation_Load(object sender, EventArgs e)
        {
            CharRace.Items.Add(Race.Human);
            CharRace.Items.Add(Race.Elf);
            CharRace.Items.Add(Race.Dwarf);
        }

        private void CharConfirm_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (GenderM.Checked)
            {
                gender = "M";
            }
            else if (GenderV.Checked)
            {
                gender = "V";
            }
            if (!string.IsNullOrEmpty(CharName.Text) && !string.IsNullOrEmpty(CharRace.Text) && gender != "")
            {
                Weapon weapon = new Weapon(Convert.ToString(MakeWeapon()));
                Character character = new Character(CharName.Text, CharRace.Text,gender, Convert.ToInt32(CharHP.Text), weapon);
                this.Close();
                Field field = new Field(character);
                field.Show();
            }
            else
            {
                MessageBox.Show("input incorrect");
            }
            
        }


    }
}
