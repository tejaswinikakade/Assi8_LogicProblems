/*using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentDay6
{
    class StopWatch
    {
        class Program
        {
            static void Main(string[] args)
            {


                StopWatch stopWatch = new StopWatch();
                object p = StopWatch.Start();

                double d = 0;
                for (int i = 0; i < 1000 * 1000 * 1000; i++)
                {
                    d += 1;
                }

                StopWatch.Stop();

                Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss\\.fffffff}", stopWatch.Elapsed);


            }
        }
    }
}*/