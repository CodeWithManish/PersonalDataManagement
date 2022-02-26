using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDataManagement
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Personal Data Management\n");
            List<PersonDetail> listPersonInCity = new List<PersonDetail>();
            AddRecords(listPersonInCity);
            Retriving_TwoRecord_ForAgeIsLessThanSixty(listPersonInCity);
            CheckingForTeenagerPerson(listPersonInCity);
            AllPersonAverageAge(listPersonInCity);
            Console.ReadLine();
        }
        private static void AddRecords(List<PersonDetail> listPersonInCity)
        {
            listPersonInCity.Add(new PersonDetail("01", "Manish", "lko", 21));
            listPersonInCity.Add(new PersonDetail("02", "nisha", "delhi", 65));
            listPersonInCity.Add(new PersonDetail("04", "Harsh", "Mumbai", 28));
            listPersonInCity.Add(new PersonDetail("05", "Raghu", "Delhi", 55));
            listPersonInCity.Add(new PersonDetail("06", "Mayank", "Jaipur", 21));
            listPersonInCity.Add(new PersonDetail("07", "Ravina", "Bangeluru", 18));
            listPersonInCity.Add(new PersonDetail("08", "Rahul", "Bangeluru", 19));
            listPersonInCity.Add(new PersonDetail("09", "Aysha", "Nagpur", 14));
            listPersonInCity.Add(new PersonDetail("10", "Rajaram", "pune", 62));

            foreach (var item in listPersonInCity)
            {
                Console.WriteLine(item.SSN + "\t" + item.Name + "\t" + item.Address + "\t " + item.Age);
            }
            Console.WriteLine("\n===============================================\n");
        }

        private static void Retriving_TwoRecord_ForAgeIsLessThanSixty(List<PersonDetail> listPersonInCity)
        {
            var result = listPersonInCity.FindAll(e => e.Age < 60).Take(2).ToList();
            foreach (PersonDetail personDetail in result)
            {
                Console.WriteLine(personDetail.Name + "\t " + personDetail.Address + "\t " + personDetail.Age);
            }
            Console.WriteLine("\n===============================================\n");
        }

        private static void CheckingForTeenagerPerson(List<PersonDetail> listPersonInCity)
        {
            if (listPersonInCity.Any(e => (e.Age >= 13 && e.Age <= 18)))
            {
                Console.WriteLine("Yes, we have some teen-Agers in the list");
            }
            else
            {
                Console.WriteLine("No, we do not have teen-Agers in the list");
            }
            Console.WriteLine("\n===============================================\n");
        }

        private static void AllPersonAverageAge(List<PersonDetail> listPersonInCity)
        {
            double avgAge = listPersonInCity.Average(e => e.Age);
            Console.WriteLine("The average of all the person's age is: " + avgAge);

        }
    }
}
