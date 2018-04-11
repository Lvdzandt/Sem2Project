using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasse
{
    class CharCreateController
    {
            enum Race
            {
                Human,
                Elf,
                Dwarf
            }

            enum WeaponSelect
            {
                Sword,
                Dagger,
                Mace
            }

            public string MakeWeapon()
            {
                Array Selection = Enum.GetValues(typeof(WeaponSelect));
                Random random = new Random();
                WeaponSelect weapon = (WeaponSelect)Selection.GetValue(random.Next(Selection.Length));
                string Selected = Convert.ToString(weapon);
                return Selected;
            }

            public void AddRace(ComboBox box)
            {
                box.Items.Add(Race.Dwarf);
                box.Items.Add(Race.Elf);
                box.Items.Add(Race.Human);
                
            }

            public void AddWeapon(ComboBox box)
            {
                box.Items.Add(WeaponSelect.Dagger);
                box.Items.Add(WeaponSelect.Mace);
                box.Items.Add(WeaponSelect.Sword);
            }

            public void AddTrait(TextBox box,string race)
            {
            if (race == "Human")
            {
                box.Text = "Normal stats";
            }
            else if (race == "Elf")
            {
                box.Text = "Speed + 1, dmg - 1";
            }
            else if (race == "Dwarf")
            {
                box.Text = "Speed -1, dmg +1";
            }
        }
        }
    }
