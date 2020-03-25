using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
   public  class _076StructAlien
    {
        struct Alien
        {
            public int X;
            public int Y;
            public int Lives;

            public Alien(int x, int y)
            {
                X = x;
                Y = y;
                Lives=3;

            }

            public override string ToString()
            {
                return $"X: {X} , Y: {Y} , Lives: {Lives}";
            }
        }

        public static void executeTest()
        {
            Alien a;
            a.X = 50;
            a.Y = 50;
            a.Lives = 3;
            Console.WriteLine($"a : {a.ToString()}");

            Alien x = new Alien(100,100);
            Console.WriteLine($"x : { x.ToString()}");

            Alien[] swarm = new Alien[100];
            Console.WriteLine($"swarm: { swarm[0].ToString() }");
            Console.ReadKey();
        }


    }
}
