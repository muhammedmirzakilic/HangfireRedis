using System;
using Hangfire;

namespace HangfireRedis.Jobs
{
    public class ErrorJob
    {
        private short _count;
        public ErrorJob()
        {
        }

        [AutomaticRetry(Attempts = 0)]
        public bool Run()
        {
            if (_count % 3 == 0)
                throw new Exception("exception mode");
            Console.WriteLine("Hello from second job");
            if (_count == 1000)
                _count = 0;
            return true;
        }
    }
}
