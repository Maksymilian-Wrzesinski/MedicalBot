using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your patien details:");
            Patient patient = new Patient();
            Console.Write("Enter Patient Name: ");
            while (!patient.SetName(Console.ReadLine(), out string errorMessage))
            {
                Console.WriteLine(errorMessage);
                Console.Write("Enter Patient Name: ");
            }
            Console.Write("Enter Patient Age: ");
            while (!patient.SetAge(Convert.ToInt32(Console.ReadLine()), out string errorMessage))
            {
                Console.WriteLine(errorMessage);
                Console.Write("Enter Patient Age: ");
            }
            Console.Write("Enter Patient Gender: ");
            while (!patient.SetGender(Console.ReadLine(), out string errorMessage))
            {
                Console.WriteLine(errorMessage);
                Console.Write("Enter Patient Gender: ");
            }
            Console.Write("Enter Patient Medical History. /Diabetes/ Press enjter for none: ");
            patient.SetMedicalHistory(Console.ReadLine());
            Console.WriteLine("HI, " + patient.GetName() + ", " + patient.GetAge() + ".");
            Console.WriteLine("Which of the following symptoms do you have:");
            Console.WriteLine("S1. Headache");
            Console.WriteLine("S2. skin_rashes");
            Console.WriteLine("S3. Dizziness");
            while (!patient.SetSymptomCode(Console.ReadLine(), out string errorMessage))
            {
                Console.WriteLine(errorMessage);
                Console.Write("Enter Correct symptom code: ");
            }
            MedicalBot doctor = new MedicalBot();
            MedicalBot.PrescribeMedication(patient);
            Console.WriteLine("your prescription"+patient.GetPrescription());
            Console.ReadKey();
    }
    }
