using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Person
    {

        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", "white", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);


            Console.WriteLine(person2.DisplayPersonInfo());
            Console.WriteLine(person3.ToString());
            Console.WriteLine(person1.ChangeFavouriteColour());
            Console.WriteLine(person4.GetAgeInTenYears());
            Console.WriteLine(person3.ToString());
            Console.WriteLine(person4.ToString());
            Console.WriteLine(person3.ToString());



            Console.ReadLine();
        }

        private int id;
        private string firstName;
        private string lastName;
        private string favouriteColour;
        private int age;
        private bool isWorking;

        public int PersonID { get => id; set => id= value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Favouritecolour { get => favouriteColour; set => favouriteColour = value;  }
        public int Age { get=> age; set => age = value; }
        public bool Isworking { get =>isWorking; set => isWorking = value; }

        public Person (int id, string firstName,string lastName,string favouriteColour,int age, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            Favouritecolour = favouriteColour;
            Age = age;
            Isworking= isWorking; 
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += "PersonID:" + PersonID + "\n";
            formatted += "FirstName:" + firstName + "\n";
            formatted += "LastName:" + lastName + "\n";
            formatted += "Favouritecolour:" + favouriteColour + "\n";
            formatted += "Age:" + age + "\n";
            formatted += "Isworking:" + isWorking + "\n";
            return formatted;

        }
        public string DisplayPersonInfo()
        {
            string formatted = "";
            formatted += id + ":" + firstName + "" + lastName + "'s" + "favourite colour is" + favouriteColour;
            return formatted;

        }

        public string ChangeFavouriteColour()
        {
            string formatted = "";
            formatted += id + ":" + firstName + "" + lastName + "'s" + "favourite colour is:white";
            return formatted;
        }
        public string GetAgeInTenYears()
        {
            string formatted = "";
            age = age + 10;

            formatted += firstName + "" + lastName + "'s Age in 10 years is:" + age;
            age = age - 10;

            return formatted;
        }
        
    }
}
