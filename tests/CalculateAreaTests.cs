using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateArea;

namespace Tests
{
    [TestClass]
    public class CalculateAreaTests
    {
        [TestMethod]
        public void square_area_should_be_25_with_side_5()
        {
           var square = new Square(5.0f);
           var result = square.GetArea();
           Assert.IsTrue(result == 25.0f);
        }

        
        [TestMethod]
        public void traingle_area_should_4_with_base_2_and_height_4()
        {
           var triangle = new Triangle(2f, 4f);
           var result = triangle.GetArea();
           Assert.IsTrue(result == 4f);
        }
    }
}
