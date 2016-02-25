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

        public Game(int[,] newGrid)
        {
            generation = (int[,])newGrid.Clone();

            generationCount = 1;

            width = generation.GetLength(1);
            height = generation.GetLength(0);

            lastGeneration = new int[height, width];
        }


        public int GenerationCount
        {
            get { return generationCount; }
        }


    }


}
