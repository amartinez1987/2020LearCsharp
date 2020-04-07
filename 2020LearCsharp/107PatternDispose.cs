using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _107PatternDispose
    {
        class ResourceHolder : IDisposable
        {
            bool disposed = false;

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            public virtual void Dispose(bool disposing)
            {
                if (disposed)
                    return;
                if (disposing)
                {

                }
            }

            ~ResourceHolder()
            {
                Dispose(false);
            }
        }

        public static void executeTest()
        {
            ResourceHolder r = new ResourceHolder();
            r.Dispose();
        }
    }
}
