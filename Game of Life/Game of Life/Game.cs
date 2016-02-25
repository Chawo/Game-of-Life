using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    class Game
    {

        int[,] generation;
        int[,] lastGeneration;
        int generationCount;
        int width;
        int height;

        public Game(int[,] newGame)
        {
            generation = (int[,])newGame.Clone();

            generationCount = 1;

            width = generation.GetLength(1);
            height = generation.GetLength(0);

            lastGeneration = new int[height, width];
        }


        public int GenerationCount
        {
            get { return generationCount; }
        }

        private int Neighbours(int x, int y)
        {
            int count = 0;

            // Check for x - 1, y - 1
            // 
            if (x > 0 && y > 0)
            {
                if (generation[y - 1, x - 1] == 1)
                    count++;
            }

            // Check for x, y - 1
            if (y > 0)
            {
                if (generation[y - 1, x] == 1)
                    count++;
            }

            // Check for x + 1, y - 1
            if (x < width - 1 && y > 0)
            {
                if (generation[y - 1, x + 1] == 1)
                    count++;
            }

            // Check for x - 1, y
            if (x > 0)
            {
                if (generation[y, x - 1] == 1)
                    count++;
            }

            // Check for x + 1, y
            if (x < width - 1)
            {
                if (generation[y, x + 1] == 1)
                    count++;
            }

            // Check for x - 1, y + 1
            if (x > 0 && y < height - 1)
            {
                if (generation[y + 1, x - 1] == 1)
                    count++;
            }

            // Check for x, y + 1
            if (y < height - 1)
            {
                if (generation[y + 1, x] == 1)
                    count++;
            }

            // Check for x + 1, y + 1
            if (x < width - 1 && y < height - 1)
            {
                if (generation[y + 1, x + 1] == 1)
                    count++;
            }

            return count;
        }

        public void WriteNeighbours()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    Console.Write("{0}", Neighbours(x, y));
                Console.WriteLine();
            }
        }

        public void ProcessGeneration()
        {
            int[,] nextGeneration = new int[height, width];

            lastGeneration = (int[,])generation.Clone();

            generationCount++;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (generation[y, x] == 0 && Neighbours(x, y) == 3)
                        nextGeneration[y, x] = 1;
                    if (generation[y, x] == 1 &&
                           (Neighbours(x, y) == 2 || Neighbours(x, y) == 3))
                        nextGeneration[y, x] = 1;
                }
            }

            generation = (int[,])nextGeneration.Clone();
        }

        public void DrawGeneration()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    Console.Write("{0}", generation[y, x]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int AliveCells()
        {
            int count = 0;

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    if (generation[y, x] == 1)
                        count++;

            return count;
        }

    }


}
