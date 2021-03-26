using System.Runtime.CompilerServices;
//Added so i could access the properties in unit testing project
[assembly: InternalsVisibleTo("Question2UnitTest")]
namespace Question2
{
    public class StringPosition
    {
        internal char DuplicatedLetter {get;set;}
        internal int DuplicatedPosition { get; set; }
    }
}