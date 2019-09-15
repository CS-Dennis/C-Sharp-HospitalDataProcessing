using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HospitalDataAnalysis
{
    public class HospitalDataProcessor
    {
        //attributes
        StreamReader originalData;
        public List<Hospital> Hospitals { get; set; }
        public List<Hospital> SearchResults { get; set; }
        private List<Hospital> _Hospitals = new List<Hospital>();
        private List<Hospital> _SearchResults = new List<Hospital>();

        //constructor
        public HospitalDataProcessor(string dataPath)
        {
            
            this.originalData = new StreamReader(dataPath);
            loadData();
        }


        //methods
        //reading and loading data
        public void loadData()
        {
            var dataLine = "";
            var dataLineFields = new List<string>();
            var hospital = new Hospital();

            //to skip first line of data - header
            dataLine = originalData.ReadLine();
            while ((dataLine = originalData.ReadLine())!=null)
            {
                dataLineFields = new List<string>(dataLine.Split('\t'));
                hospital = new Hospital() {ProviderID = int.Parse(dataLineFields[0]), HospitalName=dataLineFields[1], Address= dataLineFields[2], City= dataLineFields[3], State= dataLineFields[4], ZIPCode= int.Parse(dataLineFields[5]) ,CountyName= dataLineFields[6], PhoneNumber=long.Parse(dataLineFields[7]), HospitalType= dataLineFields[8], HospitalOwnership= dataLineFields[9], EmergencyServices= dataLineFields[10], MeetsCriteriaForMeaningfulUseOfEHRs= dataLineFields[11], HospitalOverallRating= dataLineFields[12], HospitalOverallRatingFootnote= dataLineFields[13], MortalityNationalComparison= dataLineFields[14], MortalityNationalComparisonFootnote= dataLineFields[15], SafetyOfCareNationalComparison= dataLineFields[16], SafetyOfCareNationalComparisonFootnote= dataLineFields[17], ReadmissionNationalComparison= dataLineFields[18], ReadmissionNationalComparisonFootnote= dataLineFields[19], PatientExperienceNationalComparison= dataLineFields[20], PatientExperienceNationalComparisonFootnote= dataLineFields[21], EffectivenessOfCareNationalComparison= dataLineFields[22], EffectivenessOfCareNationalComparisonFootnote= dataLineFields[23], TimelinessOfCareNationalComparison= dataLineFields[24], TimelinessOfCareNationalComparisonFootnote= dataLineFields[25], EfficientUseOfMedicalImagingNationalComparison= dataLineFields[26], EfficientUseOfMedicalImagingNationalComparisonFootnote= dataLineFields[27], Location= dataLineFields[28] };
                _Hospitals.Add(hospital);
            }

            Hospitals = _Hospitals;
            originalData.Close();
        }

        
        //find all hospitals by state that are government owend with meaningful use of EHR and same as or above the national average of patient experience
        public void HospitalByStateGovernmentMeaningfulUseEHR(string state)
        {
            var results = from hospital in _Hospitals
                          where hospital.State == state && hospital.HospitalOwnership.ToLower().Contains("government") && hospital.MeetsCriteriaForMeaningfulUseOfEHRs.ToLower().Equals("true") && (hospital.PatientExperienceNationalComparison.ToLower().Contains("same") || hospital.PatientExperienceNationalComparison.ToLower().Contains("above"))
                          select hospital;
            _SearchResults = results.ToList();
            SearchResults = _SearchResults;
        }


        public void displayAndWriteSearchResults(string filePath)
        {
            var fileWriter = new StreamWriter(filePath);
            fileWriter.WriteLine("Provider ID\tHospital Name\tAddress\tCity\tState\tZIP Code\tCounty Name\tPhone Number\tHospital Type\tHospital Ownership\tEmergency Services\tMeets criteria for meaningful use of EHRs\tHospital overall rating\tHospital overall rating footnote\tMortality national comparison\tMortality national comparison footnote\tSafety of care national comparison\tSafety of care national comparison footnote\tReadmission national comparison\tReadmission national comparison footnote\tPatient experience national comparison\tPatient experience national comparison footnote\tEffectiveness of care national comparison\tEffectiveness of care national comparison footnote\tTimeliness of care national comparison\tTimeliness of care national comparison footnote\tEfficient use of medical imaging national comparison\tEfficient use of medical imaging national comparison footnote\tLocation");
            
            foreach (var hospital in this.SearchResults)
            {
                Console.WriteLine($"{hospital.HospitalName}, {hospital.HospitalOwnership}, {hospital.MeetsCriteriaForMeaningfulUseOfEHRs}, {hospital.PatientExperienceNationalComparison}");
                fileWriter.WriteLine($"{hospital.ProviderID}\t{hospital.HospitalName}\t{hospital.Address}\t{hospital.City}\t{hospital.State}\t{hospital.ZIPCode}\t{hospital.CountyName}\t{hospital.PhoneNumber}\t{hospital.HospitalType}\t{hospital.HospitalOwnership}\t{hospital.EmergencyServices}\t{hospital.MeetsCriteriaForMeaningfulUseOfEHRs}\t{hospital.HospitalOverallRating}\t{hospital.HospitalOverallRatingFootnote}\t{hospital.MortalityNationalComparison}\t{hospital.MortalityNationalComparisonFootnote}\t{hospital.SafetyOfCareNationalComparison}\t{hospital.SafetyOfCareNationalComparisonFootnote}\t{hospital.ReadmissionNationalComparison}\t{hospital.ReadmissionNationalComparisonFootnote}\t{hospital.PatientExperienceNationalComparison}\t{hospital.PatientExperienceNationalComparisonFootnote}\t{hospital.EffectivenessOfCareNationalComparison}\t{hospital.EffectivenessOfCareNationalComparisonFootnote}\t{hospital.TimelinessOfCareNationalComparison}\t{hospital.TimelinessOfCareNationalComparisonFootnote}\t{hospital.EfficientUseOfMedicalImagingNationalComparison}\t{hospital.EfficientUseOfMedicalImagingNationalComparisonFootnote}\t{hospital.Location}");
            }
            fileWriter.Close();

        }

    }
}
