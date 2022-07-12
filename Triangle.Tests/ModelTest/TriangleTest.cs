using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleChecker;

namespace TriangleChecker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_OneSideNotLargerThanTwoSides_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(2, 2, 4));
    }

    [TestMethod]
    public void IsTriangle_OneSideNotLargerThanTwoSides_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsTriangle(2, 2, 3));
    }

//     [TestMethod]
//     public void IsLeapYear_MultiplesOfOneHundred_False()
//     {
//       LeapYear testLeapYear = new LeapYear();
//       Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
//     }
  }
}