using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimpleCsFR
{
    internal class Armor : Equipement
    {

        int defensePoint;

        public Armor() //Constructeur qui génère une valeur aléatoire de points de défense
        {
            Random rnd = new Random();
            this.defensePoint = rnd.Next(1, 5);

        }

        public int DefensePoint()
        {
            return defensePoint;
        }

        public override void PickUp(Character c) // Ajoute les points de défense au perso qui aura récupérer l'armure
        {
            //c.Def += defensePoint
        }
    }
}
