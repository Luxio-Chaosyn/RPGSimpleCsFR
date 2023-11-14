using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimpleCsFR
{
    internal abstract class Equipement
    {   
        // donne un bonus en fonction d'une valeur (int) donnée par le constructeur
        public abstract void PickUp(Character c);
    }
}
