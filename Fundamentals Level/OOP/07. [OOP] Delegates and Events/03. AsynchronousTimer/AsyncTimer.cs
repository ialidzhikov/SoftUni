using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    public class AsyncTimer
    {
        public AsyncTimer(Action methodToExecute, int ticks, double interval)
        {
            this.MethodToExecute = methodToExecute;
            this.Ticks = ticks;
            this.Interval = interval;
        }

        public Action MethodToExecute { get; set; }

        public int Ticks { get; set; }

        public double Interval { get; set; }

        public Task StartTimer()
        {
            return Task.Run(() =>
            {
                for (int ticks = this.Ticks; ticks > 0; ticks--)
                {
                    this.MethodToExecute.Invoke();
                    Thread.Sleep((int) this.Interval);
                }
            });
        }
    }
}
