# C-Sharp-HospitalDataProcessing
Welcome to C# HospitalDataprocessing project!


This simple project is performing a quick data analysis on a public health dataset - Hospital_General_Information.txt (https://catalog.data.gov/dataset/hospital-general-information)

# Purpose:
Choose all hospitals from Texas (or any other state as you choose) that are government owned, meaningful use of EHRs enabled, and same as or above the national average of patient expierence, then create a new tab-delimited file. Test the runtime speed of this program wrriten in C#.

# Dataset Description:
Hospital_General_Information.txt (3.6 MB) (https://catalog.data.gov/dataset/hospital-general-information) with 29 columns and 5335 rows (including a header).

# How to run the code:
There are three classes that are AppRun.cs, Hospital.cs and HospitalDataProcessor.cs. AppRun.cs has the Main() function to run this program.

On Windows: please put the dataset (Hospital_General_Information.txt) in C:\temp\ folder (or you can change the dataset location path in AppRun.cs and change move the dataset to a different location accordingly)

On Mac/Linux: please change the dataset location path in AppRun.cs and change move the dataset to a different location accordingly.

# Reesults:
This program was run on a MacBook Pro (Retina, 15-inch, Mid 2014), 2.2 GHz Intel Core i7, 16 GB 1600 MHz DDR3 for 10 times.
Each runtime durations are (in milliseconds) 55, 56, 56, 55, 56, 56, 57, 56, 57, 58. The average time duration is 56.2 milliseconds.

Created by Nan Ye - LinkedIn https://www.linkedin.com/in/nanyegis/
