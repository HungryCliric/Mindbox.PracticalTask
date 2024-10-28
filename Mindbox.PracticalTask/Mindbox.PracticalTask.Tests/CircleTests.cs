using Mindbox.PracticalTask.Shapes.Circle;

namespace Mindbox.PracticalTask.Tests;

[TestFixture]
public class CircleTests
{
    [Test]
    public void TestCircleArea()
    {
        var circle = new Circle
        {
            Radius = 5
        };

        var area = circle.CalculateArea();
        Assert.IsTrue(area.IsCorrect);
        Assert.AreEqual(Math.PI * 25, area.Result, 1e-10);
    }
    
    [Test]
    public void TestCircleAreaWithIncorrectFields()
    {
        var circle = new Circle
        {
            Radius = -5
        };
        var area = circle.Validate();
        Assert.IsFalse(area.IsCorrect);
    }
}