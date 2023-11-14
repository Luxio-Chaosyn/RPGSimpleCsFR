using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimpleCsFR
{
    public class ICharactere : Character
    {

        const int ATK = 20;
        const int DEF = 100;
     
        private int _lvl;
        public string name { get; set; }
        public string lvl { get; set; }
        
        

        public ICharactere(string nom)
        {
            atk = 20;
            def = 100;
            name= nom;
        }
        // Attack:
        // Prend un autre objet Character en argument et revois un booléen disant si l'attaque a réussi ou échouer
        public override bool Attack()
        { 
           
          int luck = Roll(1,2)
                if (luck == 1)
            {
                return false;
            }
            return true;
        }

        // Defend:
        // Sera appelé dans la méthode attack, retourne le score de défense de la cible
        public override int Defend(Character c)
        {
            return c.def;
        }

        // Damages:
        // Sera appelé apres l'attaque si elle a réussi et infligera des dégats à la cible
        public override void Damage(Character c)
        {
            bool r = Attack();
            if(r)
            {
                Console.WriteLine("Attaque réussi")
                c.def = c.def - atk;
            }
            Console.WriteLine("Attaque échoué")

        }

        // LevelUp:
        // fait augmenter les stats du Character, remet ses pv au max
        public override void LevelUp(Character c)
        {
            if (c.isDead)
            {
                lvl += 1;
                def = DEF + lvl * 0.30
                atk = ATK + lvl * 0.30
            }
        }

        public bool isDead()
        {
            if (def <= 0)
            {
                return true;
            }
        }

        public static int Roll(int min, int max)
        {
            return rand.Next(min, max);
        }

    }
}
