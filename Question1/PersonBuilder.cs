using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    //implementation of the interdace includes logic for Id Number Validation
    public class PersonBuilder : IPersonBuilder
    {
        Person Person = new Person();
        public DateTime ValidateDoB(string id)
        {
            //used ParseExact to get the format in yymmdd
            return Person.DateOfBirth = DateTime.ParseExact(id.Substring(0, 6), "yyMMdd", CultureInfo.InvariantCulture);
        }

        public string ValidateGender(string id)
        {
            if (int.Parse(id.Substring(6, 4)) >= 0000 && int.Parse(id.Substring(6, 4)) <= 4999)
            {
                return Person.Gender = "Female";
            }
            else 
            {
                return Person.Gender = "Male";
            }
        }

        public bool ValidatetisSouthAfricanCitizen(string id)
        {  
            Person.isSouthAfricanCitizen = id.Substring(10, 1) == "0" ? true : false;
            return Person.isSouthAfricanCitizen;
        }

        public bool ValidateisValidIDNumber(string id)
        {
            int sum = 0;
            int digit = 0;
            int oddsum = 0;
            //loop starts at rightmost value
            for (int i = id.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    sum += Convert.ToInt32(id[i].ToString());
                }
                else
                {
                    //doubles the second digits
                    digit = int.Parse(id[i].ToString()) * 2;
                    //adds the digits together eg 16 = 1+6 = 7  
                    while (digit != 0)
                    {
                        oddsum += digit % 10;
                        digit /= 10;
                    }

                }
            }
            int result = sum + oddsum;
            //checking if valid 
            if (result % 10 == 0)
            {
                return Person.isValidIDNumber = true;
            }
            else
            {
                return Person.isValidIDNumber = false;
            }
            
        }
        // returns person object
        public  Person GetPerson()
        {
            return Person;
        }
    }
}
