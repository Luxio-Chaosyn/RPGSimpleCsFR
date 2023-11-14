﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimpleCsFR
{
    public class ECharactere : Character
    {

        const int ATK = 20;
        const int DEF = 100;
        public int lvl { get; set; }
        
        

        public ECharactere(string name)
        {
            atk = ATK;
            def = DEF;
            nom= name;
        }
        // Attack:
        // Prend un autre objet Character en argument et revois un booléen disant si l'attaque a réussi ou échouer
        public override bool Attack()
        {
            int luck = Rng.Roll(1, 2)
            
                if (luck == 1)
            {
                return false;
            }
            return true;
        }



        // Damages:
        // Sera appelé apres l'attaque si elle a réussi et infligera des dégats à la cible
        public override void Damage(Character c)
        {
            bool r = Attack();
            if (r)
            {
                Console.WriteLine("Attaque réussi");
                c.def = c.def - atk;
                Console.WriteLine("Vous avez infligé " + atk + " degats ");
                return;
            }

            Console.WriteLine("Attaque échoué");

        }

        // LevelUp:
        // fait augmenter les stats du Character, remet ses pv au max
        public override void LevelUp()
        {
                lvl += 1;
                def = DEF + lvl * 0.30;
                atk = ATK + lvl * 0.30;
            
        }

        public bool isDead()
        {
            if (def <= 0)
            {
                Console.WriteLine(nom + " est mort ");
                return true;
            }
            return false;
        }

    }
}
