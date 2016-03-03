using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_exercises_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Write first number: ");
            //int x = int.Parse(Console.ReadLine());

            //Console.Write("Write second number: ");
            //int y = int.Parse(Console.ReadLine());

            //Console.Write("Write third number: ");
            //int z = int.Parse(Console.ReadLine());

            //// villkor
            //bool flag = true;

            //var number = new Klass();
            //number.CheckCondition(x, y, z);



            //Console.Write("Decimal".PadRight(10));
            //Console.Write("ASCII".PadRight(10));
            //Console.Write("Hex".PadRight(10));
            //Console.WriteLine();

            //int min = 0;
            //int max = 128;
            //for (int i = min; i < max; i++)
            //{
            //    // Get ascii character.
            //    char c = (char)i;

            //    // Get display string.
            //    string display = string.Empty;
            //    if (char.IsWhiteSpace(c))
            //    {
            //        display = c.ToString();
            //        switch (c)
            //        {
            //            case '\t':
            //                display = "\\t";
            //                break;
            //            case ' ':
            //                display = "space";
            //                break;
            //            case '\n':
            //                display = "\\n";
            //                break;
            //            case '\r':
            //                display = "\\r";
            //                break;
            //            case '\v':
            //                display = "\\v";
            //                break;
            //            case '\f':
            //                display = "\\f";
            //                break;
            //        }
            //    }
            //    else if (char.IsControl(c))
            //    {
            //        display = "control";
            //    }
            //    else
            //    {
            //        display = c.ToString();
            //    }
            //    // Write table row.
            //    Console.Write(i.ToString().PadRight(10));
            //    Console.Write(display.PadRight(10));
            //    Console.Write(i.ToString("X2"));
            //    Console.WriteLine();

            //    var hej = new Klass();
            //    hej.CheckCondition(x, z, y, flag);
            //}

            //int[] arr = new int[] { 10, 50, 60, 70, 20, 10, 30, 40, 53, 12 };
            //Console.ReadKey();

            ///////////////////////////////////
            ///////////  nr 5 & 6      ///////
            /////////////////////////////////

            int[,] arr = new int[20, 20];
            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                int x = random.Next(20);
                int y = random.Next(20);
                arr[x, y] = 1;
            }

            Print(arr);
        }

        public static void Print(int[,] arr)
        {


            foreach (var value in arr)
            {
                if (value == 0)
                {
                    Console.Write(" ");
                }
                else if (value > 0)
                {
                    Console.Write("*");
                }
            }
        }
    }

 }
        




//{
//               Game game = new Game();
//               int[,] arr = new int[20, 20];
//               //Add some random values to the array
//               Random R = new Random();
//               for (int i = 0; i < 50; i++)
//               {
//                   int x = R.Next(20);
//                   int y = R.Next(20);
//                   arr[x, y] = 1;
//               }
//               while (true)
//               {
//                   Console.Clear();
//                   game.Print(arr);
//                   //Process the array and get a modified array back
//                   arr = game.ProcessGame(arr);

//                   Console.ReadKey();
//               }
//           }
//var Game = new Game();

//Console.Write("Write first number: ");
//int x = int.Parse(Console.ReadLine());

//Console.Write("Write second number: ");
//int y = int.Parse(Console.ReadLine());

//Console.Write("Write third number: ");
//int z = int.Parse(Console.ReadLine());

//    // villkor
//    // om x större y och x mindre y
//    Console.WriteLine("HEJ EMIL");
//    Console.WriteLine("Hejhej");
//}

//bool flag = true;
//public void CheckCondition(int x, int y, int z, bool flag)
//{

//}
