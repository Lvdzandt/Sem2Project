using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Weapon
    {
        public string name { get; private set; }
        public int damage { get; private set; }

        public Weapon(string _name)
        {
            name = _name;
            damage = DmgSet(_name);
        }

        private int DmgSet(string name)
        {
            int dmg = 0;
            if (name == "Sword")
            {
                dmg = 5;
            }
            else if (name == "Dagger")
            {
                dmg = 3;
            }
            else if (name == "Mace")
            {
                dmg = 7;
            }
            return dmg;
        }

        public int WeaponDMG
        {
            get { return damage; }
            private set { damage = value; }
        }
    }
}
