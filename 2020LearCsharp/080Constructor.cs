using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _080Constructor
    {
        class Alien
        {
            public int X;
            public int Y;
            public int Lives;

            #region Contructor and overload
            public Alien(int x, int y)
            {
                if (x < 0 || y < 0)
                    throw new ArgumentOutOfRangeException("Invalid Position");
                X = x;
                Y = y;
                Lives = 3;
            }

            public Alien(int x, int y, int lives)
            {
                if (x < 0 || y < 0)
                    throw new ArgumentOutOfRangeException("Invalid Position");
                X = x;
                Y = y;
                Lives = lives;
            }

            static Alien()
            {

            }

            #endregion


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
                swarm[i] = new Alien(0, 0);

            Console.WriteLine($"swarm[0] {swarm[0]}");

            Console.ReadKey();
        }
    }
}
