using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject2
{
     class Ability_Orc
    {
        public string Torch;
        public string weapon_throw;
        public string break_the_lock;
        public string death_blow;
        public Ability_Orc(string Torch,string waepon_throw,string break_the_lock,string death_blow)
        {
            this.Torch = Torch;
            this.weapon_throw = waepon_throw;
            this.break_the_lock = break_the_lock;
            this.death_blow = death_blow;

        }
    }


}
