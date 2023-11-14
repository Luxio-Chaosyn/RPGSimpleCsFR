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
     
        private bool _isAlive = true;
        private int _lvl;


        public string name { get; set; }
        public string lvl { get; set; }


        public bool Alive
        {
            get { return _isAlive; }
            set
            {
                if (def <= 0)
                {
                    _isAlive = false;
                }
            }
        }


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
                c.def = c.def - atk;
            }
            

        }

        // LevelUp:
        // fait augmenter les stats du Character, remet ses pv au max
        public override void LevelUp()
        {
            
        }
    }
}
