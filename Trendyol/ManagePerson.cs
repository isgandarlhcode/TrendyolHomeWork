using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class ManagePerson
    {
        public void PersonManager(){

        Person person1 = new Person();

            person1.ID = GetHashCode();
            Console.Write("Adinizi daxil edin : ");
            person1.NamePerson = Console.ReadLine();
            Console.Write("Soyadinizi daxil edin : ");
            person1.surnamePerson = Console.ReadLine();
            Console.Write("Ata adinizi daxil edin : ");
            person1.fatherPerson = Console.ReadLine();
            Console.Write("Dogum tarixinizi daxil edin : ");
            person1.DateOfBirthPerson = DateTime.Parse(Console.ReadLine());
            Console.Write("E-mailinizi daxil edin : ");
            person1.emailPerson = Console.ReadLine();
            Console.Write("Sifresinizi daxil edin : ");
            person1.passwordPerson = Console.ReadLine();
            Console.Write("Cinsiyyetinizi daxil edin : ");
            person1.genderPerson = Console.ReadLine();
            Console.WriteLine("Addresinizi daxil edin : ");
            string response = string.Empty;
            do
            {
                string item = Console.ReadLine();
                person1.addAddressPerson(item);
                Console.WriteLine("Basqa adress varmi ? : ");
                response = Console.ReadLine();

            } while (response == "he");

            string phoneresponse = string.Empty;

            Console.WriteLine("Telefonunuzu daxil edin : ");
            do
            {
                string item = Console.ReadLine();
                person1.addphonePerson(item);
                Console.WriteLine("Basqa nomre varmi ? : ");
                phoneresponse = Console.ReadLine();

            } while (phoneresponse == "he");

            person1.GiveInformationPerson();
        }

    }
}
