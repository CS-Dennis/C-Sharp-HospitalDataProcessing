using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HospitalDataAnalysis
{
    public class Hospital
    {

        //Meets criteria for meaningful use of EHRs	Hospital overall rating	Hospital overall rating footnote	Mortality national comparison	Mortality national comparison footnote	Safety of care national comparison	Safety of care national comparison footnote	Readmission national comparison	Readmission national comparison footnote	Patient experience national comparison	Patient experience national comparison footnote	Effectiveness of care national comparison	Effectiveness of care national comparison footnote	Timeliness of care national comparison	Timeliness of care national comparison footnote	Efficient use of medical imaging national comparison	Efficient use of medical imaging national comparison footnote	Location
        public int ProviderID { get; set; }
        public string HospitalName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZIPCode { get; set; }
        public string CountyName { get; set; }
        public long PhoneNumber { get; set; }
        public string HospitalType { get; set; }
        public string HospitalOwnership { get; set; }
        public string EmergencyServices { get; set; }
        public string MeetsCriteriaForMeaningfulUseOfEHRs { get; set; }
        public string HospitalOverallRating { get; set; }
        public string HospitalOverallRatingFootnote { get; set; }
        public string MortalityNationalComparison { get; set; }
        public string MortalityNationalComparisonFootnote { get; set; }
        public string SafetyOfCareNationalComparison { get; set; }
        public string SafetyOfCareNationalComparisonFootnote { get; set; }
        public string ReadmissionNationalComparison { get; set; }
        public string ReadmissionNationalComparisonFootnote { get; set; }
        public string PatientExperienceNationalComparison { get; set; }
        public string PatientExperienceNationalComparisonFootnote { get; set; }
        public string EffectivenessOfCareNationalComparison { get; set; }
        public string EffectivenessOfCareNationalComparisonFootnote { get; set; }
        public string TimelinessOfCareNationalComparison { get; set; }
        public string TimelinessOfCareNationalComparisonFootnote { get; set; }
        public string EfficientUseOfMedicalImagingNationalComparison { get; set; }
        public string EfficientUseOfMedicalImagingNationalComparisonFootnote { get; set; }
        public string Location { get; set; }
    }
}
