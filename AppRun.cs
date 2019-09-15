using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalDataAnalysis
{
    class AppRun
    {
        public static void Main()
        {
            var timeNow = DateTime.Now.Millisecond;
            HospitalDataProcessor processor1 = new HospitalDataProcessor(@"C:\temp\Hospital_General_Information.txt");

            processor1.HospitalByStateGovernmentMeaningfulUseEHR("TX");
            processor1.displayAndWriteSearchResults(@"C:\temp\new.txt");

            var runtimeDuration = DateTime.Now.Millisecond - timeNow;
            Console.WriteLine(runtimeDuration);

            Console.ReadKey();
        }

        
    }
}
