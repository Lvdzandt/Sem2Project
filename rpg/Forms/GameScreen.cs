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
    partial class GameScreen : Form
    {
        Klasse.Character Player;
        Klasse.Enemy enemy;
        Klasse.Field Field;
        public GameScreen(Klasse.Character character, Klasse.Field field)
        {
            InitializeComponent();
            Player = character;
            Field = field;
        }

        private void Field_Load(object sender, EventArgs e)
        {
            PlayerName.Text = Player.name;
            PlayerHP.Text = Convert.ToString(Player.currHP);
            PlayerRace.Text = Player.race;
            PlayerWeapon.Text = Player.weapon.name;
        }

       

        
    }
}
