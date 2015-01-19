using System;
using System.Threading;
using Core.Contracts.Services;
using ThreadState = Core.Models.Multithreading.ThreadState;

namespace Core.Services.Calculation
{
    public class TestService : ITestService
    {
        private TimeSpan[] _completionTimes;

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
            var start = DateTime.Now;
            var namedState = state as ThreadState;
            for (var i = namedState.Start; i < namedState.Stop; i++)
            {
                var result = i / 4 + i / 8;
            }

            _completionTimes[namedState.ThreadNumber] = DateTime.Now.Subtract(start);
            namedState.Countdown.Signal();
        }

        public TimeSpan[] Loop32Mt(int threadCount)
        {
            _completionTimes = new TimeSpan[threadCount];

            using (var finished = new CountdownEvent(1))
            {
                for (var i = 0; i < threadCount; i++)
                {
                    finished.AddCount();
                    _completionTimes[i] = new TimeSpan();
              
                    var state = new ThreadState
                    {
                        Start = UInt32.MaxValue/threadCount*i,
                        Stop = UInt32.MaxValue/(threadCount)*(i+1),
                        Countdown = finished,
                        ThreadNumber = i
                    };
                    ThreadPool.QueueUserWorkItem(Loop32, state);
                }

                finished.Signal();
                finished.Wait();
            }

            return _completionTimes;
        }
    }
}
