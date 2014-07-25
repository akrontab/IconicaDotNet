using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IconicaPieces;

namespace IconicaDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();

            while (!game.isGameOver())
            {
                game.TakeTurn();
            }

            Console.WriteLine("Game Over!!!");
            Console.Read();
        }
    }
}
