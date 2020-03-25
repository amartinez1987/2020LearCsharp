using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _078CreateReferenceType
    {
        class Alien
        {
            public int X;
            public int Y;
            public int Lives;


            public Alien(int x , int y )
            {
                X = x;
                Y = y;
                Lives = 3;
            }
            public override string ToString()
            {
                return $"X: {X} , Y: {Y} , Lives: {Lives}";
            }


        }

        public static void executeTest()
        {
            Alien x = new Alien(100, 100);
            Console.WriteLine($"x: {x}");

            Alien[] swarm = new Alien[100];
            for (int i = 0; i < swarm.Length; i++)
                swarm[i] = new Alien(0,0);

            Console.WriteLine($"swarm[0] {swarm[0]}");

            Console.ReadKey();
        }
    }
}
