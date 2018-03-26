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
        Character Player;
        Enemy enemy;
        Field Field;
        public GameScreen(Character character, Field field)
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

        private void button3_Click(object sender, EventArgs e)
        {
            enemy = new Enemy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player.AttackEnemey(enemy);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(enemy.ToString());
        }

        
    }
}
