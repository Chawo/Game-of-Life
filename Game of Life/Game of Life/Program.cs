using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] grid = new int[,]
   {
        { 1, 0, 0, 0, 0, 0, 0, 0, 1, 1,},
        { 0, 0, 1, 0, 0, 1, 0, 0, 0, 0,},
        { 0, 1, 1, 0, 1, 1, 1, 0, 0, 0,},
        { 0, 1, 0, 0, 0, 1, 0, 0, 0, 0,},
        { 0, 0, 0, 0, 0, 0, 0, 1, 0, 1,},
        { 0, 0, 0, 0, 1, 0, 0, 0, 1, 1,},
        { 0, 1, 0, 0, 1, 0, 0, 1, 0, 0,},
        { 1, 1, 0, 0, 1, 0, 0, 0, 0, 0,},
   };

            Game lifeGrid = new Game(grid);

            Console.WriteLine("Generation 0");
            lifeGrid.DrawGeneration();
            Console.WriteLine();

            while (lifeGrid.AliveCells() > 0)
            {
                string response;

                Console.WriteLine();
                Console.WriteLine("Generation {0}", lifeGrid.GenerationCount);

                lifeGrid.ProcessGeneration();
                lifeGrid.DrawGeneration();

                Console.WriteLine();

                if (lifeGrid.AliveCells() == 0)
                {
                    Console.WriteLine("Every one died!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Press <Enter> to contiune or n<Enter> to quit.");

                    response = Console.ReadLine();

                    if (response == "n" || response == "N")
                        break;
                }
            }
        }
    }
}
 
