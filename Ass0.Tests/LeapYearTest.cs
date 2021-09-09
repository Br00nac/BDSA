using System;
using System.IO;
using Xunit;

namespace Ass0.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void LeapYearRule1Test()
        {

            //Assert
            Assert.True(LeapYear.IsLeapYear(1644));

        }

        [Fact]
        public void LeapYearRule2Test(){


            //Assert
            Assert.False(LeapYear.IsLeapYear(1700));

        }

        [Fact]
        public void LeapYearRule3Test(){


            //Assert
            Assert.True(LeapYear.IsLeapYear(1600));

        }

        [Fact]
        public void IsBeyond1582(){

            //Arrange?
            Action action = () => LeapYear.IsLeapYear(1548);

            //Assert
            Assert.Throws<Exception>(action);


        }

        [Fact]
        public void IsInputAnInteger(){

            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Console.SetIn(new StringReader("notAnInteger"));
            LeapYear.Main(new string[0]);
            
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Input is not an integer", output);


        }

       
        
    }
}
