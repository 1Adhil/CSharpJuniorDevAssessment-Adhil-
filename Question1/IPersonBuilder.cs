using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
 //Created an interface for all methods    
    public interface IPersonBuilder
    {
        DateTime ValidateDoB(string id);
        string ValidateGender(string id);
        bool ValidatetisSouthAfricanCitizen(string id);
        bool ValidateisValidIDNumber(string id);
        Person GetPerson();
    }
}
