using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _2020LearCsharp
{
    public class _102ModifyExpressionTree
    {
        public class MultiplyToAdd : ExpressionVisitor
        {
            public Expression Modify(Expression expression)
            {
                return Visit(expression);
            }

            protected override Expression VisitBinary(BinaryExpression b)
            {
                if (b.NodeType == ExpressionType.Multiply)
                {
                    Expression left = this.Visit(b.Left);
                    Expression right = this.Visit(b.Right);
                    return Expression.Add(left, right);
                }

                return base.VisitBinary(b);
            }


        }

        public static void exectuteTest()
        {
            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");

            BinaryExpression squareOption = Expression.Multiply(numParam, numParam);

            Expression<Func<int, int>> square = Expression.Lambda<Func<int, int>>(squareOption, new ParameterExpression[] { numParam });

            Func<int, int> doSquare = square.Compile();

            Console.WriteLine($"Result square {doSquare(2)}");

            Console.WriteLine();

            Console.ReadKey();

            MultiplyToAdd m = new MultiplyToAdd();

            Expression<Func<int, int>> addExpression = (Expression<Func<int, int>>) m.Modify(square);

            Func<int, int> doAdd = addExpression.Compile();

            Console.WriteLine($"Result add {doAdd(4)}");

            Console.WriteLine();




            Console.ReadKey();
        }
    }
}
