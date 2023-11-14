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

        }

        //check toute les positions (en haut, en bas, a droite et a gauche) et check si on peut se deplacer dessus (c'est a dire, si c'est un mur ou pas)
        public bool[] GetMoveOptions()
        {
            bool[] MoveOptions = [false, false, false, false];


            return (MoveOptions);
        }

        //bouge sur la case demandé
        public void Move(int x, int y)
        {

        }

        //boucle principale du jeu
        public void Game()
        {

        }

        public int StartGame()
        {
            return (0);
        }
    }
}
Console.WriteLine("Hello, World!");
