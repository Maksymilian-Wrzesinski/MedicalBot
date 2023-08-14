using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


    public class Patient
    {
        public string name;
        public int age;
        public string gender;

        public string Medication = "null";
        public string MedicalHistory = "null";
        public string symptomCode;
        public string prescription;

        public string GetName()
        {
            return name;
        }

        public bool SetName(string name, out string errorMessage)
        {
            bool isValid;
            if (name == null || name.Length == 0) {
                isValid = false;
                errorMessage = "string cannot be null or empty";
                return isValid;
            }
            else if (name.Length == 1)
            {
                isValid = false;
                errorMessage = "string must have at least 2 characters";
                return isValid;
            }

            isValid = true;
            errorMessage = "";
            this.name= name;
            return isValid;

        }
        public int GetAge()
        {
            return age;
        }

        public bool SetAge(int age, out string errorMessage)
        {
            bool isValid;
            if(age<0 || age>100)
            {
                isValid = false;
                errorMessage = "age cannot be negative and higher than 100";
                return isValid;
            }
            isValid = true;
            errorMessage = "";
            this.age = age;
            return isValid;
        }
        public string GetGender()
        {
            return gender;
        }
        public bool SetGender(string gender, out string errorMessage)
        {
            bool isValid;
            if(gender != "Male" && gender!= "Female"){
                isValid = false;
                errorMessage = " gender must be male or female";
                return isValid;
            }
            isValid = true;
            errorMessage = "";
            this.gender = gender;
            return isValid;
        }
        public string GetMedicalHistory() { 
            return MedicalHistory;
        }
        public void SetMedicalHistory(string MedicalHistory)
        {
            this.MedicalHistory = MedicalHistory;
        }
        public bool SetSymptomCode(string symptomCode, out string errorMessage) 
        {
            bool isValid;
            if(symptomCode != "S1" && symptomCode != "s1" && symptomCode != "S2" && symptomCode != "s2" &&  symptomCode != "S3" && symptomCode != "s3")
            {
                isValid = false;
                errorMessage = "Symptom Code should be s1, s2 or s3";
                return isValid;
            }
            isValid = true;
            errorMessage = "";
            this.symptomCode = symptomCode;
            return isValid;
        }
        public string GetSymptoms() 
        {
            string symptom;
            switch (this.symptomCode) 
            { 
                case "S1":
                case "s1": symptom = "Headache";break;
                case "S2":
                case "s2": symptom = "skin_rashes";break;
                case "S3":
                case "s3": symptom = "Dizziness";break;
                default: symptom = "unknown"; break;
            }
            return symptom;

        }
        public string GetPrescription()
        {
            return prescription;
        }
        public void SetPrescription(string prescription)
        {
            this.prescription = prescription;
        }
    }

