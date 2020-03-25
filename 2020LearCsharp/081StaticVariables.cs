using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
  public  class _081StaticVariables
    {

        class Alien
        {
            public static int Max_Lives = 99;

            public int X;
            public int Y;
            public int Lives;

            #region Contructor and overload
            public Alien(int x, int y, int lives)
            {
                if (x < 0 || y < 0)
                    throw new ArgumentOutOfRangeException("Invalid Position");
               

                if (Lives > Max_Lives)
                    throw new Exception("Invalid Lives");

                X = x;
                Y = y;
                Lives = lives;

            }

            #endregion


            #region method

            public bool removeLives(int liveToRemove)
            {
                Lives = Lives - liveToRemove;
                if (Lives <= 0)
                {
                    Lives = 0;
                    X = -1000;
                    Y = -1000;
                    return false;

                }
                else
                {
                    return true;
                }
            }
            #endregion


            public override string ToString()
            {
                return $"X: {X} , Y: {Y} , Lives: {Lives}";
            }


        }

        public static void executeTest()
        {
            Alien x = new Alien(100, 100,3);
            Console.WriteLine($"x: {x}");

            Alien[] swarm = new Alien[100];
            for (int i = 0; i < swarm.Length; i++)
                swarm[i] = new Alien(0, 0,3);

            Console.WriteLine($"swarm[0] {swarm[0]}");

            Console.ReadKey();
        }
    }
}
