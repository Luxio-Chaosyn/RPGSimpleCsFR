using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimpleCsFR
{
    internal class Labyrinth
    {
        // créer le labyrinthe, commence par faire une grille pleine de # puis au harzard enlève 3/5 en les remplaçant par des espace
        public void Generate(int x, int y)
        {
            char[,] maze = new char[x, y];
            
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    maze[x, y] = '#';
                }


            }


        }

        // au hazard rajoute nb 'M' dans le labyrinthe
        public void Populate(int nb)
        {


        }

        // au hazard rajoute nb 'T' dans le labyrinthe
        public  void Furbish(int nb)
        {


        }

        //renvoie la nature de la case demandé
        public void observe(int x, int y) { 
        
        }

    }
}
