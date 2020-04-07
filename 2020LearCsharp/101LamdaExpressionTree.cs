using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _2020LearCsharp
{
    public class _101LamdaExpressionTree
    {
        public static void executeTest()
        {
            ParameterExpression numParam = Expression.Parameter(typeof(int),"num");

            BinaryExpression squareOption = Expression.Multiply(numParam,numParam);

            Expression<Func<int, int>> square = Expression.Lambda<Func<int, int>>(squareOption, new ParameterExpression[] { numParam });

            Func<int, int> doSquare = square.Compile();

            Console.WriteLine($"Result square {doSquare(2)}");

            Console.ReadKey();
        }
    }
}
