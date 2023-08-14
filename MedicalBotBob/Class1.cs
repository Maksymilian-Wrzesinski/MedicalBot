using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


    public class MedicalBot
    {
        const string BotName = "Bob";
        public string medicineName;
        public string dosage;
        static string GetBotName()
        {
            return BotName;
        }
        
        public static void PrescribeMedication(Patient patient)
        {
            if (patient.GetSymptoms() == "Headache")
            {
                patient.SetPrescription("ibuprofen" + GetDosage("ibuprofen"));
            }
            else if (patient.GetSymptoms() == "skin_rashes")
            {
                patient.SetPrescription("diphenhydramine" + GetDosage("diphenhydramine"));
            }
            else if (patient.GetSymptoms() == "Dizziness")
            {
                if (patient.GetMedicalHistory() == "diabetes")
                {
                    patient.SetPrescription("metformin" + GetDosage("metformin"));
                }
                else { patient.SetPrescription("dimenhydrinate" + GetDosage("dimenhydrinate")); }
            }
            else {
                System.Console.WriteLine("Wrong diagnosis");
            }
            string GetDosage(string medicineName)
            {
                if (medicineName == "ibuprofen")
                {
                    if (patient.GetAge() < 18)
                    {
                        return "400 mg";
                    }
                    else
                    {
                        return "800 mg";
                    }
                }
                if (medicineName == "diphenhydramine")
                {
                    if (patient.GetAge() < 18)
                    {
                        return "50 mg";
                    }
                    else
                    {
                        return "300 mg";
                    }
                }
                if (medicineName == "dimenhydrinate")
                {
                    if (patient.GetAge() < 18)
                    {
                        return "50 mg";
                    }
                    else
                    {
                        return "400 mg";
                    }
                }
                if (medicineName == "metformin")
                {
                    return "500 mg";
                }
                return "unknown";
            }
        }
       
    }

