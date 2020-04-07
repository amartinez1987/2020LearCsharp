using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
   public  class _095IEnumerable
    {
        class EnumeratorThings:IEnumerator<int>,IEnumerable
        {
            int count;
            int limit;

            public int Current { get { return count; } }

            object IEnumerator.Current { get { return count; } }



            public void Dispose() { }

            public bool MoveNext()
            {
                if (++count == limit)
                    return false;
                else
                    return true;
            }

            public void Reset()
            {
                count = 0;
            }

            public IEnumerator GetEnumerator()
            {
                return this;
            }          

            public EnumeratorThings(int limit)
            {
                count = 0;
                this.limit = limit;
            }
        }

        class EnumeratorThings2 : IEnumerable<int>
        {            
            int limit;
            public IEnumerator<int> GetEnumerator()
            {
                for (int i = 1; i < 10; i++)
                {
                    yield  return i;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public EnumeratorThings2(int limit)
            {              
                this.limit = limit;
            }
        }
        public static void executeTest()
        {
            EnumeratorThings enumerator = new EnumeratorThings(10);
            foreach (int e in enumerator)
            {
                Console.WriteLine($"Result {e}");
            }
            Console.ReadKey();

            EnumeratorThings2 enumerator2 = new EnumeratorThings2(10);
            foreach (int e in enumerator2)
            {
                Console.WriteLine($"Result {e}");
            }
            Console.ReadKey();
        }
    }
}
