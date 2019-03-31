using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5_4_
{
    class Character
    {
        public IPersonage personage { private get; set; }
        public IWeapon weapon { private get; set; }
        public ITeam team { private get; set; }
    
        public Character(IPersonage personage, IWeapon weapon, ITeam team)
        {
            this.personage = personage;
            this.weapon = weapon;
            this.team = team;
        }
        public string ShowCharacter()
        {
            return personage.TypePersonage()+" "+weapon.TypeWeapon()+" "+team.TypeTeam();
        }
    }
}
