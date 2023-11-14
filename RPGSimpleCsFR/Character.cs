using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimpleCsFR
{
    public abstract class Character
    {
        // Propriétés
        

        public int atk {  get; set; }
        public int def {  get; set; }
        public string nom;

        //  Méthodes

        // Constructeur:
        // Initialise l'instance en demandant un nom s'il n'est pas dans les argument ou simplement on assignera le nom donné en argument


        // Attack:
        // Prend un autre objet Character en argument et revois un booléen disant si l'attaque a réussi ou échouer
        public abstract bool Attack();

      
        // Damages:
        // Sera appelé apres l'attaque si elle a réussi et infligera des dégats à la cible
        public abstract void Damage(Character c);

        // LevelUp:
        // fait augmenter les stats du Character, remet ses pv au max
        public abstract void LevelUp();

        public abstract bool isDead();



    }
}
