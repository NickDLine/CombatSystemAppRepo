using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Classes
{
    class Unit
    {
        public int WeaponSkill { get; set; }
        public int Strength { get; set; }
        public int Toughness{ get; set; }
        public int Wounds { get; set; }
        public int Attacks { get; set; }
        public int NumberOfModels { get; set; }
        public int AttackValueOfWholeUnit { get; set; }
        public string UnitName { get; set; }

        public Unit(int weaponSkillInput, int strengthInput, int toughnessInput, int woundsInput, int attacksInput, int startingNumberOfModels, string unitNameInput)
        {
            this.WeaponSkill = weaponSkillInput;
            this.Strength = strengthInput;
            this.Toughness = toughnessInput;
            this.Wounds = woundsInput;
            this.Attacks = attacksInput;
            this.NumberOfModels = startingNumberOfModels;
            this.AttackValueOfWholeUnit = Attacks * NumberOfModels; // Need to update this on construction
            this.UnitName = unitNameInput;
        }
    }
}
