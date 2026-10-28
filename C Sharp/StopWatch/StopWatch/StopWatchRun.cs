using System;

namespace StopWatch
{
    internal class StopWatchRun
    {
        private DateTime _initialStartTime;
        private DateTime _startTime;
        private bool _isStart = false;
        private TimeSpan _totalTimeSpan;

        public void Start()
        {
            if (!_isStart)
            {
                _isStart = true;
                _startTime = DateTime.Now;
                _initialStartTime = _startTime;
                Console.WriteLine("Time started at {0}", _startTime.ToString("HH:mm:ss.ff"));
                Console.WriteLine("Choose desired operation from the options above.");
            }

        }

        public void Stop()
        {
            if (_isStart)
            {
                _isStart = false;
                DateTime stopTime = DateTime.Now;

                TimeSpan timeSpan = stopTime.Subtract(_startTime);
                _totalTimeSpan += timeSpan;

                Console.WriteLine("Time stopped at: {0}", stopTime.ToString("HH:mm:ss.ff"));
                Console.WriteLine("Elapsed Time: {0}", timeSpan.ToString(@"hh\:mm\:ss\.ff"));
                Console.WriteLine("Total Timespan: {0} ", _totalTimeSpan.ToString(@"hh\:mm\:ss\.ff"));
                Console.WriteLine("Choose desired operation from the options above.");
            }

        }
    }
}