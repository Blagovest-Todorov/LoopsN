using System;

namespace LoopsN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // #####           // reads numbers n and l -> generates alphabeticaly all passwords of 5 symbols
            // 1####
            // 11aa5
            // 
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
           // int count = 0;

            for (int first = 1; first <= n; first++)
            {
                for (int sec = 1; sec <= n; sec++)
                {
                    for (char third = 'a'; third < 'a' + l; third++)
                    {
                        for (char forth = 'a'; forth < 'a' + l; forth++)
                        {
                            for (int fifth = 1; fifth <= n; fifth++)
                            {
                                if (fifth > first && fifth > sec)
                                {
                                    Console.Write($"{first}{sec}{third}{forth}{fifth} ");
                                    // count++;

                                }

                            }


                        }
                    }

                }

            }
            Console.WriteLine();
            Console.WriteLine(count);


        }
    }
}
