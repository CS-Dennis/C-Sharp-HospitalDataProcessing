using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HospitalDataAnalysis
{
    class AppRun
    {
        public static void Main()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            HospitalDataProcessor processor1 = new HospitalDataProcessor(@"/Users/dennis/Desktop/cSharp/Hospital_General_Information.txt");

            processor1.HospitalByStateGovernmentMeaningfulUseEHR("TX");
            processor1.displayAndWriteSearchResults(@"/Users/dennis/Desktop/cSharp/new.txt");

            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);

            Console.ReadKey();
        }

        
    }
}
