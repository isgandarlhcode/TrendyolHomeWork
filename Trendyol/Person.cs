using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    class Person
    {
        public Person()
        {
            this.addressPerson = new List<string>();
            this.phonePerson = new List<string>();

        }
            
            public int ID {get ; set; }
            public string NamePerson { get; set; }
            public string surnamePerson { get; set; }

            public string fatherPerson { get; set; }

            public DateTime DateOfBirthPerson { get; set; }

            public string emailPerson { get; set; }

            public string passwordPerson { get; set; }

            public List <string> phonePerson { get; set; }

            public List<string> addressPerson { get; set; }

            public string genderPerson { get; set; }

            public void addphonePerson (string newpasswordPerson)
            {
                this.phonePerson.Add(newpasswordPerson);
            }

            public void addAddressPerson(string newadressPerson)
            {
                this.phonePerson.Add(newadressPerson);
            }

            
            public void GiveInformationPerson()
        {

            StringBuilder info = new StringBuilder();

            info.Append(" Adi : " + this.NamePerson + "\n");
            info.Append(" Soyadi : " + this.surnamePerson + "\n");
            info.Append(" Ata adi : " + this.fatherPerson + "\n");
            info.Append(" E-maili : " + this.emailPerson + "\n");
            info.Append(" Sifresi : " + this.passwordPerson + "\n");
            info.Append(" Dogum tarixi :" + this.DateOfBirthPerson + "\n");
            info.Append(" Cinsi : " + this.genderPerson + "\n");

            for (int i = 0; i < this.phonePerson.Count; i++)
            {
                info.Append(" Telefon : " + this.phonePerson[i] + "\n");
            }
            for (int i = 0; i < this.addressPerson.Count ; i++)
            {
                info.Append(" Adress : " + this.addressPerson[i] + "\n");
            }
            Console.WriteLine(info);
        }


    }


    }
