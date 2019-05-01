using System;

namespace StairCaseProblem
{
    class Program
    {
        static void StairCase(int n)
        {
            //Print out a staircase of hash symbols
            var space = " ";
            var stair = "#";
            var spaceCount = n - 1;
            var stairCount = 1;

            for(var i = 0; i < n; i++)
            {
                //print out the spaces
                for(var spaces = spaceCount; spaces > 0; spaces--)
                {
                    Console.Out.Write(space);
                }
                spaceCount--;
                for(var stairs = 0; stairs < stairCount; stairs++)
                {
                    Console.Out.Write(stair);
                }
                stairCount++;
                Console.Out.Write("\r\n");
            }
        }
        static void Main(string[] args)
        {
            StairCase(10);
            Console.ReadKey();
        }
    }
}
