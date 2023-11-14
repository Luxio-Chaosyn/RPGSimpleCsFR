using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimpleCsFR
{
    internal abstract class Labyrinth
    {
        // créer le labyrinthe, commence par faire une grille pleine de # puis au harzard enlève 3/5 en les remplaçant par des espace
        public abstract void Generate(int x, int y);

        // au hazard rajoute nb 'M' dans le labyrinthe
        public abstract void Populate(int nb);
        // au hazard rajoute nb 'T' dans le labyrinthe
        public abstract void Furbish(int nb);
    }
}
