using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Question2.Question1UnitTest
{
    [TestClass()]
    public class StringPositionBuilderTests
    {
        [TestMethod()]
        public void DuplicatedCharacters_Test()
        {
            //Arrange
            StringPosition obj = new StringPosition();
            var builder = new StringPositionBuilder();
            //Act
            builder.DuplicatedCharacters("letter");
            //Assert
            List<StringPosition> expected = new List<StringPosition>() 
            {
            new StringPosition {DuplicatedLetter= 't',DuplicatedPosition=  3 }
            };
            List<StringPosition> actual = builder.DuplicatedCharacters("letter");
            //Assert.IsNotNull(actual[0]);
            CollectionAssert.Equals(expected, actual);
        }
    }
}