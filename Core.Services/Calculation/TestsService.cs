using System;
using System.Threading;

namespace Core.Services.Calculation
{
    public class TestService
    {
        public void Loop64()
        {
            for (UInt64 i = 0; i < UInt64.MaxValue; i++)
            {
                var result = i/4 + i/8;
            }
        }

        public void Loop16()
        {
            for (UInt16 i = 0; i < UInt16.MaxValue; i++)
            {
                var result = i / 4 + i / 8;
            }
        }

        public void Loop32(object state)
        {
            var namedState = state as Tuple<long, long>;
            for (var i = namedState.Item1; i < namedState.Item2; i++)
            {
                var result = i / 4 + i / 8;
            }
        }

        public void Loop32Mt(int threadCount)
        {
            ManualResetEvent eventX = new ManualResetEvent(false);

            for (var i = 0; i < threadCount; i++)
            {
                var state = new Tuple<long, long>(UInt32.MaxValue/threadCount*i-1,UInt32.MaxValue/threadCount);
                ThreadPool.QueueUserWorkItem(Loop32, state);
            }

            eventX.WaitOne();
        }
    }
}
