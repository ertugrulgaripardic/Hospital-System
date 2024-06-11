using System;
using System.Collections.Generic;

namespace HospitalInformationSystem
{
    class Program
    {
        static List<Patient> patients = new List<Patient>();
        static List<Doctor> doctors = new List<Doctor>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Hospital Information System");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Add Doctor");
                Console.WriteLine("3. List Patients");
                Console.WriteLine("4. List Doctors");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPatient();
                        break;
                    case "2":
                        AddDoctor();
                        break;
                    case "3":
                        ListPatients();
                        break;
                    case "4":
                        ListDoctors();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddPatient()
        {
            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Patient Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Patient Disease: ");
            string disease = Console.ReadLine();

            Patient newPatient = new Patient(name, age, disease);
            patients.Add(newPatient);

            Console.WriteLine("Patient added successfully!");
        }

        static void AddDoctor()
        {
            Console.Write("Enter Doctor Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Doctor Specialty: ");
            string specialty = Console.ReadLine();

            Doctor newDoctor = new Doctor(name, specialty);
            doctors.Add(newDoctor);

            Console.WriteLine("Doctor added successfully!");
        }

        static void ListPatients()
        {
            Console.WriteLine("Patient List:");
            foreach (var patient in patients)
            {
                Console.WriteLine(patient);
            }
        }

        static void ListDoctors()
        {
            Console.WriteLine("Doctor List:");
            foreach (var doctor in doctors)
            {
                Console.WriteLine(doctor);
            }
        }
    }

    class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Disease { get; set; }

        public Patient(string name, int age, string disease)
        {
            Name = name;
            Age = age;
            Disease = disease;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Disease: {Disease}";
        }
    }

    class Doctor
    {
        public string Name { get; set; }
        public string Specialty { get; set; }

        public Doctor(string name, string specialty)
        {
            Name = name;
            Specialty = specialty;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Specialty: {Specialty}";
        }
    }
}
