using System;
using Hangfire;
using HangfireRedis.Jobs;

namespace HangfireRedis.Hangfire
{
    public class HangfireServices
    {
        public HangfireServices()
        {
        }
        public static void InitJobs()
        {
            RecurringJob.AddOrUpdate<SuccessJob>(jobs => jobs.Run(), "*/5 * * * *");
            RecurringJob.AddOrUpdate<ErrorJob>(jobs => jobs.Run(), "* * * * *");
        }
    }
}
