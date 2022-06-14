using System;
using System.Threading.Tasks;

namespace Host_tester.Code
{


    internal class Timer
    {
        public int Interval
        {
            set; get;
        } = 10000;
        public Boolean isTimerRunning { get; set; } = true;

        public Func<int> TimedFunction { set; get; } = () => { return 0; };// function that will be executed at the start of each interval

        public async Task StartAsync()
        {
            isTimerRunning = true; 
            while (isTimerRunning)
            {
                TimedFunction();
                await Task.Delay(Interval);
            }
        }
        public void stopTimer() { this.isTimerRunning = false; }

    }
}
