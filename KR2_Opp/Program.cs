using System;

namespace KR2_Opp
{
    class Program
    {
        struct organizazia
        {
            public struct osoba
            {
                public string name;
                public string sur_name;
                public string father_name;
                public float data_of_birth;

                public void osoba_display()
                {
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Surname: {sur_name}");
                    Console.WriteLine($"Middle name: {father_name}");
                    Console.WriteLine($"Date of birth: {data_of_birth}");
                }
            }
            public struct sluzbovez
            {
                public string organization;
                public string specialty;
                public string position;
                public float salary;
                public int experience;

                public void sluzbovez_display()
                {
                    Console.WriteLine($"Organization: {organization}");
                    Console.WriteLine($"Specialty for diploma: {specialty}");
                    Console.WriteLine($"Position: {position}");
                    Console.WriteLine($"Salary: {salary}k UAH");
                    Console.WriteLine($"Experience: {experience} years");
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Persons:");
                //person 1
                organizazia.osoba per1_org;
                organizazia.sluzbovez per1_sluz;
                per1_org.name = "Vasia";
                per1_org.sur_name = "Pupkin";
                per1_org.father_name = "Oleksandrovich";
                per1_org.data_of_birth = 11.1999f;
                per1_sluz.organization = "sirius";
                per1_sluz.specialty = "economy";
                per1_sluz.position = "junior guardian";
                per1_sluz.salary = 10.5f;
                per1_sluz.experience = 1;
                per1_org.osoba_display();
                per1_sluz.sluzbovez_display();
                Console.WriteLine("_________");

                // person 2
                organizazia.osoba per2_org;
                organizazia.sluzbovez per2_sluz;
                per2_org.name = "Anton";
                per2_org.sur_name = "Vasiliev";
                per2_org.father_name = "Bogdanovich";
                per2_org.data_of_birth = 5.1983f;
                per2_sluz.organization = "atb";
                per2_sluz.specialty = "manager";
                per2_sluz.position = "manager";
                per2_sluz.salary = 11.5f;
                per2_sluz.experience = 3;
                per2_org.osoba_display();
                per2_sluz.sluzbovez_display();
                Console.WriteLine("_________");

                // person 3
                organizazia.osoba per3_org;
                organizazia.sluzbovez per3_sluz;
                per3_org.name = "Denis";
                per3_org.sur_name = "Petrovich";
                per3_org.father_name = "Glebovich";
                per3_org.data_of_birth = 7.2000f;
                per3_sluz.organization = "none";
                per3_sluz.specialty = "it-manager";
                per3_sluz.position = "freelance";
                per3_sluz.salary = 13f;
                per3_sluz.experience = 4;
                per3_org.osoba_display();
                per3_sluz.sluzbovez_display();
                Console.WriteLine("_________");

                // person 4
                organizazia.osoba per4_org;
                organizazia.sluzbovez per4_sluz;
                per4_org.name = "Vania";
                per4_org.sur_name = "Hasimov";
                per4_org.father_name = "Eduardovich";
                per4_org.data_of_birth = 1.1994f;
                per4_sluz.organization = "GlobalLogic";
                per4_sluz.specialty = "Computer Science";
                per4_sluz.position = "Full-stack";
                per4_sluz.salary = 17f;
                per4_sluz.experience = 7;
                per4_org.osoba_display();
                per4_sluz.sluzbovez_display();
                Console.WriteLine("_________");

                // person 5
                organizazia.osoba per5_org;
                organizazia.sluzbovez per5_sluz;
                per5_org.name = "Viktor";
                per5_org.sur_name = "Klimov";
                per5_org.father_name = "Ivanovich";
                per5_org.data_of_birth = 9.1998f;
                per5_sluz.organization = "Viakom";
                per5_sluz.specialty = "Electronics";
                per5_sluz.position = "board manufacturer";
                per5_sluz.salary = 11f;
                per5_sluz.experience = 1;
                per5_org.osoba_display();
                per5_sluz.sluzbovez_display();
                Console.WriteLine("_________");

                Console.WriteLine("Enter work experience:");

                int count = 0;

                int k = Convert.ToInt32(Console.ReadLine());

                if (per1_sluz.experience >= k)
                {
                    Console.WriteLine($"{per1_org.name} - {per1_sluz.experience} year");
                    count++;
                }
                if (per2_sluz.experience >= k)
                {
                    Console.WriteLine($"{per2_org.name} - {per2_sluz.experience} year");
                    count++;
                }
                if (per3_sluz.experience >= k)
                {
                    Console.WriteLine($"{per3_org.name} - {per3_sluz.experience} year");
                    count++;
                }
                if (per4_sluz.experience >= k)
                {
                    Console.WriteLine($"{per4_org.name} - {per4_sluz.experience} year");
                    count++;
                }
                if (per5_sluz.experience >= k)
                {
                    Console.WriteLine($"{per5_org.name} - {per5_sluz.experience} year");
                    count++;
                }
                Console.WriteLine($"{count} person have more work experience than {k} year(s)."); 
            }
        }
    }
}
