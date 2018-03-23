using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    class Character
    {

        public string name { get; private set; }
        public string race { get; private set; }
        public string gender { get; private set; }
        public Weapon weapon { get; private set; }
        public int maxHP { get; private set; }
        public int currHP { get; private set; }


        public Character(string _name, string _race,string _gender, int _maxHP, Weapon _weapon)
        {
            name = _name;
            race = _race;
            gender = _gender;
            maxHP = _maxHP;
            currHP = _maxHP;
            weapon = _weapon;
        }

        public void AttackEnemey(Enemy enemy)
        {
            enemy.TakeDmg(weapon.WeaponDMG);
        }

        

        public override string ToString()
        {
            return string.Format("Name: {0} Race: {1} HP: {2} Weapon: {3}", name, race, currHP,weapon.name);
        }
    }
}
