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
        Character character;
        Weapon weapon;
        CharCreateController Controller = new CharCreateController();
        Field Field;
      
        

        public CharacterCreation()
        {
            InitializeComponent();
        }


        private void CharacterCreation_Load(object sender, EventArgs e)
        {
            Controller.AddRace(CharRace);
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
                weapon = new Weapon(Controller.MakeWeapon());
                character = new Character(CharName.Text, CharRace.Text,gender, weapon);
                Field = new Field(DiffSelect.Text);
                this.Close();
                GameScreen gamefield = new GameScreen(character,Field);
                gamefield.Show();
            }
            else
            {
                MessageBox.Show("input incorrect");
            }
            
        }


    }
}
