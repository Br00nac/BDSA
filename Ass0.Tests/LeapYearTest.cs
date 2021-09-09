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


            //Assert
            Assert.False(LeapYear.IsLeapYear(1548));


        }

       
        
    }
}
