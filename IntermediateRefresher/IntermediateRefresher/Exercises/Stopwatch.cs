using System;

namespace IntermediateRefresher.Exercises
{
    class Stopwatch
    {
        private DateTime? _startTime;
        private DateTime? _endTime;

        public void Start()
        {
            if (_startTime != null)
            {
                throw new InvalidOperationException("Stopwatch already started");
            }

            _startTime = DateTime.Now;
        }

        public void Stop()
        {

            if (_endTime != null)
            {
                throw new InvalidOperationException("Stopwatch already stopped");
            }
            _endTime = DateTime.Now;

            var elapsedTime = _endTime - _startTime;

            if (elapsedTime.HasValue)
            {
                var elapsed = (TimeSpan)elapsedTime;
                Console.WriteLine(elapsed.TotalMilliseconds);
            }

            _startTime = null;
            _endTime = null;
        }

        public static void Run()
        {

            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                stopwatch.Stop();

                stopwatch.Start();
                stopwatch.Stop();

                stopwatch.Start();
                stopwatch.Stop();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }



        }
    }
}
