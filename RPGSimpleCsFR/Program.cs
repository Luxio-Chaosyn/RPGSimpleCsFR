// See https://aka.ms/new-console-template for more information

namespace RPGSimpleCsFR
{
    public class SimpleRPG
    {
        private int px = 0;
        private int py = 0;

        private Character player;
        private Labyrinth maze;

        //trouve une position valide (un espace) et place le joueur dessus (set px et py a l'endroit)
        public void GetStartPosition()
        {

            bool ok = false;
            do
            {
                for (int i = 0; i < 50; i++)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        if (maze.observe(i, j) == ' ')
                        {
                            px = i;
                            py = j;
                            ok= true;
                            break;
                        }
                    }
                }
            } while (!ok);
        }
        //check toute les positions (en haut, en bas, a droite et a gauche) et check si on peut se deplacer dessus (c'est a dire, si c'est un mur ou pas)
        public bool[] GetMoveOptions()
        {
            bool[] MoveOptions = { false, false, false, false };
            if (px>0 && maze.observe(px - 1, py) == ' ')
            {
                MoveOptions[3] = true;
            }
            if (px<50 && maze.observe(px + 1, py) == ' ')
            {
                MoveOptions[2] = true;
            }
            if (py>0 && maze.observe(py - 1, px) == ' ')
            {
                MoveOptions[1] = true;
            }
            if (py<50 && maze.observe(py + 1, px) == ' ')
            {
                MoveOptions[0] = true;
            }
            return (MoveOptions);
        }

        //bouge sur la case demandée
        public void Move(int x, int y)
        {
            if (maze.observe(x, y)==' ')
            {
                px = x;
                py = y;
            }
        }

        //boucle principale du jeu
        public void Game()
        {

        }

        public int StartGame()
        {
            maze.Generate(50, 50);
            return (0);
        }
    }
}
