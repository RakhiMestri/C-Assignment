using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_
{
    
        public class PatientData
        {
            public string Name { get; set; }
            public string Ansr { get; set; }
            public void patient()
            {

                ArrayList nameslist = new ArrayList();
                do
                {
                    Console.Write("Enter Patient Name: ");
                    Name = Console.ReadLine();
                    Console.Write("do you want to add more Y/N ? ");
                    Ansr = Console.ReadLine();
                    nameslist.Add(Name);
                }
                while (Ansr.ToLower() == "y");
                {
                    foreach (var item in nameslist)
                    {
                        Console.WriteLine("List of Patients " +  item);

                    }
                }
                Console.WriteLine("Total number of Patients " + nameslist.Count);

                Console.WriteLine("\nSelect one of the below options:");
                Console.WriteLine("1. Sort");
                Console.WriteLine("2. Reverse");
                Console.WriteLine("3. Remove");
                Console.WriteLine("4. Search for a name");
                Console.WriteLine("5. Exit");

            int selectedOption;
                
            while (true)
            {
                Console.WriteLine("Please enter your choice:");
                if (int.TryParse(Console.ReadLine(), out selectedOption))
                {
                    if (selectedOption == 1)
                    {
                        nameslist.Sort();
                        foreach (var patientName in nameslist)
                        {
                            Console.WriteLine(patientName);
                        }

                    }
                    else if (selectedOption == 2)
                    {
                        nameslist.Reverse();
                        foreach (var patientName in nameslist)
                        {
                            Console.WriteLine(patientName);
                        }
                    }
                    else if (selectedOption == 3)
                    {
                        Console.WriteLine("Enter the name to remove:");
                        string nameToRemove = Console.ReadLine();
                        nameslist.Remove(nameToRemove);
                        Console.WriteLine("Name removed.");
                    }
                    else if (selectedOption == 4)
                    {
                        Console.WriteLine("Enter the name to search:");
                        string nameToSearch = Console.ReadLine();
                        bool found = nameslist.Contains(nameToSearch);
                        Console.WriteLine("Name found: " + found);
                    }
                    else if (selectedOption == 5)
                    {
                        Console.WriteLine("Exiting the program...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid option (1-5).");
                }
            }


        }


        public static void Main(string[] args)
        {
            PatientData objdata = new PatientData();
            objdata.patient();
        }
    }
   


    }