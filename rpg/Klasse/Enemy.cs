using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasse
{
    class Enemy
    {
        private string name;
        private double hp;
        private string status = "Alive";

        public Enemy()
        {
            name = "Enemy 1";
            hp = 10;
        }

        public void TakeDmg(double dmgtaken)
        {
            hp = hp - dmgtaken;
            EnemyStatus();
        }

        private void EnemyStatus()
        {
            if (hp <= 0)
            {
                status = "Dead";
                hp = 0;
                MessageBox.Show(name + " has been defeated");
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} HP: {1} State: {2}", name, hp,status);
        }
    }
}
