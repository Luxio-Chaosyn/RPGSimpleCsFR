using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimpleCsFR
{
    public class SimpleRPG
    {
        private int px = 0;
        private int py = 0;

        private ECharactere player;
        private Labyrinth maze;

        //trouve une position valide (un espace) et place le joueur dessus (set px et py a l'endroit)
        private void GetStartPosition()
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
                            ok = true;
                            break;
                        }
                    }
                }
            } while (!ok);
        }
        //check toute les positions (en haut, en bas, a droite et a gauche) et check si on peut se deplacer dessus (c'est a dire, si c'est un mur ou pas)
        private bool[] GetMoveOptions()
        {
            bool[] MoveOptions = { false, false, false, false };
            if (px > 0 && maze.observe(px - 1, py) == ' ')
            {
                MoveOptions[3] = true;
            }
            if (px < 50 && maze.observe(px + 1, py) == ' ')
            {
                MoveOptions[2] = true;
            }
            if (py > 0 && maze.observe(px, py - 1) == ' ')
            {
                MoveOptions[1] = true;
            }
            if (py < 50 && maze.observe(px, py + 1) == ' ')
            {
                MoveOptions[0] = true;
            }
            return (MoveOptions);
        }

        private void Fight()
        {
            ECharactere monster = new ECharactere("Goblin");

            while (!player.isDead() && !monster.isDead())
            {
                player.Damage(monster);
                if (!monster.isDead())
                    monster.Damage(player);
            }
            if (!player.isDead())
                player.LevelUp();
        }

        //bouge sur la case demandée
        private void Move(int x, int y)
        {
            if (maze.observe(x, y) == ' ')
            {
                px = x;
                py = y;
            }
        }

        private string GetValidCmd()
        {
            string cmd = "";

            while (cmd == "")
            {
                cmd = Console.ReadLine();
                if (cmd.Length > 1)
                    cmd = "";
            }
            return (cmd);
        }

        private void ShowPath(bool[] MoveOptions)
        {
            if (MoveOptions[0])
                Console.WriteLine("1: Allez au Nord");
            if (MoveOptions[1])
                Console.WriteLine("2: Allez au Sud");
            if (MoveOptions[2])
                Console.WriteLine("3: Allez à l'Est");
            if (MoveOptions[3])
                Console.WriteLine("4: Allez à l'Ouest");
        }

        //boucle principale du jeu
        private void Game()
        {
            string cmd = "";

            while (!player.isDead())
            {
                bool[] MoveOptions = GetMoveOptions();

                ShowPath(MoveOptions);
                cmd = GetValidCmd();
                if (MoveOptions[0] && cmd == "1")
                    Move(px, py + 1);
                else if (MoveOptions[1] && cmd == "2")
                    Move(px, py - 1);
                else if (MoveOptions[2] && cmd == "3")
                    Move(px + 1, py);
                else if (MoveOptions[3] && cmd == "4")
                    Move(px - 1, py);
                else
                    Console.WriteLine("Commande non reconnue, où voulez vous allez ?");
            }
        }

        public int StartGame()
        {
            Console.WriteLine("Choisissez un nom");
            string name = Console.ReadLine();
            
            maze = new Labyrinth();
            player = new ECharactere(name);

            maze.Generate(50, 50);
            Game();
            Console.WriteLine("GAME OVER");
            return (0);
        }
    }
}