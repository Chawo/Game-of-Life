//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Extra_exercises_2
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {

//            {
//                int[,] game = new int[,]
//                {
//        { 1, 0, 0, 0, 0, 0, 0, 0, 1, 1,},
//        { 0, 0, 1, 0, 0, 1, 0, 0, 0, 0,},
//        { 0, 1, 1, 0, 1, 1, 1, 0, 0, 0,},
//        { 0, 1, 0, 0, 0, 1, 0, 0, 0, 0,},
//        { 0, 0, 0, 0, 0, 0, 0, 1, 0, 1,},
//        { 0, 0, 0, 0, 1, 0, 0, 0, 1, 1,},
//        { 0, 1, 0, 0, 1, 0, 0, 1, 0, 0,},
//        { 1, 1, 0, 0, 1, 0, 0, 0, 0, 0,},
//                };


//                var Ngame = new Game(game);


//                Console.WriteLine("Generation 0");
//                Ngame.DrawGeneration();
//                Console.WriteLine();

//                while (Ngame.AliveCells() > 0)
//                {
//                    string response;

//                    Console.WriteLine();
//                    Console.WriteLine("Generation {0}", Ngame.GenerationCount);

//                    Ngame.ProcessGeneration();
//                    Ngame.DrawGeneration();

//                    Console.WriteLine();

//                    if (Ngame.AliveCells() == 0)
//                    {
//                        Console.WriteLine("Every one died!");
//                        Console.ReadLine();
//                    }
//                    else
//                    {
//                        Console.WriteLine("Press <Enter> to contiune or n<Enter> to quit.");

//                        response = Console.ReadLine();

//                        if (response == "n" || response == "N")
//                            break;
//                    }
//                }
//            }
//        }
//    }
//}


        
//        //{
//        //               Game game = new Game();
//        //               int[,] arr = new int[20, 20];
//        //               //Add some random values to the array
//        //               Random R = new Random();
//        //               for (int i = 0; i < 50; i++)
//        //               {
//        //                   int x = R.Next(20);
//        //                   int y = R.Next(20);
//        //                   arr[x, y] = 1;
//        //               }
//        //               while (true)
//        //               {
//        //                   Console.Clear();
//        //                   game.Print(arr);
//        //                   //Process the array and get a modified array back
//        //                   arr = game.ProcessGame(arr);

//        //                   Console.ReadKey();
//        //               }
//        //           }
//        //var Game = new Game();

//        //Console.Write("Write first number: ");
//        //int x = int.Parse(Console.ReadLine());

//        //Console.Write("Write second number: ");
//        //int y = int.Parse(Console.ReadLine());

//        //Console.Write("Write third number: ");
//        //int z = int.Parse(Console.ReadLine());

//        //    // villkor
//        //    // om x större y och x mindre y
//        //    Console.WriteLine("HEJ EMIL");
//        //    Console.WriteLine("Hejhej");
//        //}

//        //bool flag = true;
//        //public void CheckCondition(int x, int y, int z, bool flag)
//        //{

//        //}
   