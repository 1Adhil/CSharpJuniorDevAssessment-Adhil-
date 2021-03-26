using Microsoft.VisualStudio.TestTools.UnitTesting;
using Question1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Question1.Question1UnitTest
{
    [TestClass()]
    public class PersonBuilderTests
    {
        [TestMethod()]
        public void Validate_DoB_Test()
        {
            //Arrange
            var builder = new PersonBuilder();
            //Act
            DateTime Dob = builder.ValidateDoB("7508305802089");
            //Assert
            DateTime  expected = new DateTime(1975,08,30);
            DateTime actual = builder.GetPerson().DateOfBirth;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void validate_gender_Test()
        {
            //arrange
            var builder = new PersonBuilder();
            //act
            string gender = builder.ValidateGender("7508305802089");
            //assert
            string expected = "Male";
            string actual = builder.GetPerson().Gender;
            Assert.AreEqual(expected,actual);
        }
        [TestMethod()]
        public void validate_isSouthAfricanCitizen_Test()
        {
            //arrange
            var builder = new PersonBuilder();
            //act
            bool Citizen = builder.ValidatetisSouthAfricanCitizen("7508300802089");
            //assert
            bool actual = builder.GetPerson().isSouthAfricanCitizen;
            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void validate_isValidIDNumber_Test()
        {
            //arrange
            var builder = new PersonBuilder();
            //act
            bool Citizen = builder.ValidatetisSouthAfricanCitizen("7508305802089");
            //assert
            //bool expected = true;
            bool actual = builder.GetPerson().isValidIDNumber;
            Assert.IsFalse(actual);
        }

    }
}