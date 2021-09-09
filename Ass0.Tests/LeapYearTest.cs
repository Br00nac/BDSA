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
            Assert.True(LeapYear.IsLeapYear(1544));

        }

        [Fact]
        public void LeapYearRule2Test(){


            //Assert
            Assert.False(LeapYear.IsLeapYear(1500));

        }

        [Fact]
        public void LeapYearRule3Test(){


            //Assert
            Assert.True(LeapYear.IsLeapYear(1600));

        }


    }
}
