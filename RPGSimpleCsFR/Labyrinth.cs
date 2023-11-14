using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimpleCsFR
{
    internal class Labyrinth
    {
        char[,] maze;

        // créer le labyrinthe, commence par faire une grille pleine de # puis au harzard enlève 3/5 en les remplaçant par des espace
        public void Generate(int x, int y)
        {
            maze= new char[x, y];
            
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    maze[x, y] = '#';
                }


            }

            int nbvide =0;

            do
            {
                int rand1 = Rng.Roll(0, x);
                int rand2 = Rng.Roll(0, y);


                if (maze[rand1, rand2]=='#')
                {
                    maze[rand1, rand2] = ' ';
                    nbvide++;

                }

            }
            while (nbvide < (x * y * 3 / 5));
            
             


        }

        // au hazard rajoute nb 'M' dans le labyrinthe
        public void Populate(int nb)
        {
            do
            {

                int rand1 = Rng.Roll(0,maze.GetLength(0));
                int rand2 = Rng.Roll(0, maze.GetLength(1));


                if (maze[rand1, rand2]= ' ')
                {
                    maze[rand1, rand2] = 'M';
                    nb--;

                }

            }
            while (nb > 0);

        }


        // au hazard rajoute nb 'T' dans le labyrinthe
        public  void Furbish(int nb)
        {
            do
            {

                int rand1 = Rng.Roll(0,maze.GetLength(0));
                int rand2 = Rng.Roll(0,maze.GetLength(1));


                if (maze[rand1, rand2]= ' ')
                {
                    maze[rand1, rand2] = 'T';
                    nb--;

                }

            }
            while (nb > 0);



        }

        //renvoie la nature de la case demandé
        public char observe(int x, int y) {
            return maze[x, y];        
        }

    }
}
