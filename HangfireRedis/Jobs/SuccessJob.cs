using System;
namespace HangfireRedis.Jobs
{
    public class SuccessJob
    {
        public SuccessJob()
        {
        }

        public bool Run()
        {
            Console.WriteLine("Hello from first job");
            return true;
        }
    }
}
