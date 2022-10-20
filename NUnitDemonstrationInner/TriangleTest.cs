using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitDemonstration;


namespace NUnitDemonstration
{
    public class TriangleTest
    {
        [TestFixture]
        public class TriangleTest1
//Vishant Kumar Kataria Test
        {

            [Test]

            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                //Arrange
                int firstAngle = 50;
                int secondAngle = 70;
                int thirdAngle = 60;

                string expected = "The triangle is valid.";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);

            }
        }
       
    }
}
