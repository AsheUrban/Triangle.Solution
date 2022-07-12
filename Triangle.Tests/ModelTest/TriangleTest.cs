using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleChecker;

namespace TriangleChecker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_OneSideNotLargerThanTwoSides_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsTriangle(2, 2, 4));
    }

    [TestMethod]
    public void IsTriangle_OneSideNotLargerThanTwoSides_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(2, 2, 3));
    }

    [TestMethod]
    public void IsEquilateral_EqualOnAllSides_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsEquilateral(2, 2, 2));
    }
    
    [TestMethod]
    public void IsEquilateral_EqualOnAllSides_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsEquilateral(2, 2, 3));
    }

    [TestMethod]
    public void IsIsosceles_EqualOnTwoSides_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsIsosceles(2, 2, 3));
    }

    [TestMethod]
    public void IsIsosceles_EqualOnTwoSides_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsIsosceles(2, 2, 2));
    }

    [TestMethod]
    public void IsScalene_NoSidesAreEqual_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsScalene(1, 2, 3));
    }
  }
}
