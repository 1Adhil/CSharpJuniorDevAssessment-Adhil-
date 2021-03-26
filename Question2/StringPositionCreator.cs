using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class StringPositionCreator
    {
        private IStringPositionBuilder _stringPositionBuilder;

        public StringPositionCreator(IStringPositionBuilder IStringPositionBuilder)
        {
            _stringPositionBuilder = IStringPositionBuilder;
        }
        //calls implementation for = DuplicatedCharacters from StringPositionBuilder
        public List<StringPosition> CreateDuplicateCheck(string data) 
        {
             return _stringPositionBuilder.DuplicatedCharacters(data);
            
        }
        public StringPosition GetStringPosition() 
        {
            return _stringPositionBuilder.GetStringPostion();
        }
    }
}
