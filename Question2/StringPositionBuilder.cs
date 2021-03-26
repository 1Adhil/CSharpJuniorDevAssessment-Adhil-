using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    //implementation for IStringPositionBuilder
    public class StringPositionBuilder : IStringPositionBuilder
    {
        private StringPosition _StringPosition = new StringPosition();
        public List<StringPosition> DuplicatedCharacters(string data)
        {
            var DupicateList = new List<StringPosition>();
            //loops @lenght -  1 of we dont get an index out of range error
            for (int i = 0; i < data.Length - 1; i++)
            {
                //compares the current char of the string to the one after to see if there is a match
                if (data[i] == data[i + 1])
                {
                    //check to exclude excludes spaces 
                    if (data[i] != ' ')
                    {
                        StringPosition obj = new StringPosition();
                        obj.DuplicatedLetter = data[i];
                        obj.DuplicatedPosition = i + 1;
                        DupicateList.Add(obj);
                    }
                }
            }
            return DupicateList;
        }

        public StringPosition GetStringPostion()
        {

            return _StringPosition;

        }
    }
}
