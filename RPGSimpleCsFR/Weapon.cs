using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimpleCsFR
{
    internal class Weapon : Equipement
    {
        private int damagePoint;

        public Weapon()// Génére aléatoirement une valeur aléatoire de points d'attaque
        {
            this.damagePoint = Rng.Roll(1, 5);
        }

        public int DamagePoint()
        { return damagePoint; }

        public override void PickUp(Character c)
        {
            //c.Atk += damagePoint
        }
    }
}
