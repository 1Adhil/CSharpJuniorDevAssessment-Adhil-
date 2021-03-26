using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class PersonCreator
    {
        //object of interface
        private IPersonBuilder _personBuilder;
        //Default constructor to set values
        public PersonCreator(IPersonBuilder IPersonBuilder)
        {
            _personBuilder = IPersonBuilder;
        }
        //method to call personBuilder implementation
        public void CreatePerson(string id)
        {
            _personBuilder.ValidateDoB(id);
            _personBuilder.ValidateGender(id);
            _personBuilder.ValidatetisSouthAfricanCitizen(id);
            _personBuilder.ValidateisValidIDNumber(id);
        }
        //returns person object
        public Person GetPerson()
        {
            return _personBuilder.GetPerson();
        }
    }
}
