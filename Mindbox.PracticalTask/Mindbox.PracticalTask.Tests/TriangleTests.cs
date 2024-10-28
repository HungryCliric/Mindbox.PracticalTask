using Mindbox.PracticalTask.Shapes.Triangle;

namespace Mindbox.PracticalTask.Tests;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void TestTriangleRightAngled()
    {
        var triangle = new Triangle
        {
            A = 3,
            B = 4,
            C = 5
        };
        var isRight = triangle.IsRightAngled();
        Assert.IsTrue(isRight.IsCorrect);
        Assert.IsTrue(isRight.Result);
    }
    
    [Test]
    public void TestTriangleIsNotRightAngled()
    {
        var triangle = new Triangle
        {
            A = 3,
            B = 4,
            C = 6
        };
        var isRight = triangle.IsRightAngled();
        Assert.IsTrue(isRight.IsCorrect);
        Assert.IsFalse(isRight.Result);
    }
    
    [Test]
    public void TestTriangleWithIncorrectFields()
    {
        var triangle = new Triangle
        {
            A = 1,
            B = -4,
            C = 12
        };
        var isRight = triangle.Validate();
        Assert.IsFalse(isRight.IsCorrect);
    }
    
    
    [Test]
    public void TestTriangleArea()
    {
        var triangle = new Triangle
        {
            A = 3,
            B = 4,
            C = 6
        };

        var area = triangle.CalculateArea();
        Assert.IsTrue(area.IsCorrect);
        Assert.AreEqual(5.33, Math.Round(area.Result * 100) / 100);
    }
}