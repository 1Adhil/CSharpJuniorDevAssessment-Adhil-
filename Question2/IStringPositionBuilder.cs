using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    //Interface 
    public interface IStringPositionBuilder
    {
        List<StringPosition> DuplicatedCharacters(string data);
        StringPosition GetStringPostion();
    }
}
