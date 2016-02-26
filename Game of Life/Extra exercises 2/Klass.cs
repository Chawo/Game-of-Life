using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_exercises_2
{
    class Klass
    { 

        public int GetMaxValueFromArray
        {
            get; set;
        }
        public int GetMinValueFromArray
        {
            get; set;
        }
        public int CalculateAverageValueFromArray
        {
            get; set;

        }

        public void CheckCondition(int x, int y, int z, bool flag = true)
        {
            if (y > 10 && y < 20 || z == 0)
            {
                Console.WriteLine(flag);
            }
            else if (z > 10 && z < 20)
            {
                Console.WriteLine(flag);
            }
            else if (x == 5 && y == 3 && z >= 99)
            {
                flag = false;
                Console.WriteLine("You failed");
            }
            {
                flag = false;
                Console.WriteLine("You failed");
 
            }
        }
    }
}
