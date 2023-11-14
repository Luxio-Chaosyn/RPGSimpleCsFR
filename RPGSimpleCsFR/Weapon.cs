using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimpleCsFR
{
    internal class Weapon : Equipement
    {
        int damagePoint;

        public Weapon()
        {
            Random rnd = new Random();
            this.damagePoint = rnd.Next(1, 5);
        }

        public int DamagePoint()
        { return damagePoint; }

        public override void PickUp(Character c)
        {
            //c.Atk += damagePoint
        }
    }
}
