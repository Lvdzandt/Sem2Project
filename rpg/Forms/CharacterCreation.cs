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
        Klasse.Character character;
        Klasse.CharCreateController Controller = new Klasse.CharCreateController();
        Klasse.Field Field;
      
        

        public CharacterCreation()
        {
            InitializeComponent();
        }


        private void CharacterCreation_Load(object sender, EventArgs e)
        {
            Controller.AddRace(CharRace);
            Controller.AddWeapon(WeaponSelect);
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
                Klasse.Weapon weapon = new Klasse.Weapon(WeaponSelect.Text);
                character = new Klasse.Character(CharName.Text, CharRace.Text,gender,weapon);
                Field = new Klasse.Field(DiffSelect.Text);
                this.Close();
                GameScreen gamefield = new GameScreen(character,Field);
                gamefield.Show();
            }
            else
            {
                MessageBox.Show("input incorrect");
            }
            
        }

        private void CharRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller.AddTrait(TraitBox,CharRace.Text);
        }
    }
}
