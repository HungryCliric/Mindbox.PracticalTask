using Mindbox.PracticalTask.Shapes.Circle;
using Mindbox.PracticalTask.Shapes.Shape;
using Mindbox.PracticalTask.Shapes.Triangle;

// Вычисление площади фигуры без знания типа фигуры в compile-time
var random = new Random();
var itemsCounts = 7;

var array = Enumerable.Range(0, itemsCounts).Select(_ =>
{
    var testChoice = random.NextBoolean();
    if (testChoice)
    {
        return (IShape)new Circle
        {
            Radius = random.NextDouble()
        };
    }
    else
    {
        return (IShape)new Triangle
        {
            A = random.NextDouble(),
            B = random.NextDouble(),
            C = random.NextDouble()
        };
    }
}).ToArray();

foreach (var item in array)
{
    var area = item.CalculateArea();
    if (area.IsCorrect)
        Console.WriteLine($"Площадь фигуры: {area.Result}, Тип фигуры: {item.GetType()}");
    else 
        Console.WriteLine($"Ошибка: {area.Error.Message}");
}


public static class TestExtensions
{
    public static bool NextBoolean(this Random random)
        => random.Next() > (Int32.MaxValue / 2);
}