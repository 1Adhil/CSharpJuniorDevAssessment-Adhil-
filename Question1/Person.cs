using System;
using System.Runtime.CompilerServices;
//added this  to access internal properties of the person class
[assembly: InternalsVisibleTo("Question1UnitTest")]

namespace Question1
{
    //changed internal to public to access the class
     public class Person
    {
        internal DateTime DateOfBirth { get; set; }
        internal string Gender { get; set; }
        internal bool isSouthAfricanCitizen { get; set; }
        internal bool isValidIDNumber { get; set; }
    }

}