using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasse
{
    class Character
    {

        public string name { get; private set; }
        public string race { get; private set; }
        public string gender { get; private set; }
        public Weapon weapon { get; private set; }
        public int speed { get; private set; }
        public double dmgMod { get; private set; }
        public int maxHP { get; private set; }
        public int currHP { get; private set; }


        public Character(string _name, string _race,string _gender, Weapon _weapon)
        {
            CheckRace(_race);
            name = _name;
            race = _race;
            gender = _gender;
            speed = 1;
            maxHP = 15;
            currHP = maxHP;
            weapon = _weapon;
            
        }

        private void CheckRace(string _race)
        {
            if (_race == "Elf")
            {
                speed += 1;
                dmgMod = -1;
            }
            else if(_race == "Dwarf")
            {
                speed -= 1;
                dmgMod = 1;
            }
        }

        public void AttackEnemey(Enemy enemy)
        {
            enemy.TakeDmg((weapon.WeaponDMG + dmgMod));
        }

        

        public override string ToString()
        {
            return string.Format("Name: {0} Race: {1} HP: {2} Weapon: {3}", name, race, currHP,weapon.name);
        }
    }
}
