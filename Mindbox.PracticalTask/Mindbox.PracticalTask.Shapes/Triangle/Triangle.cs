using Mindbox.PracticalTask.Common.Error;
using Mindbox.PracticalTask.Common.ErrorCodes;
using Mindbox.PracticalTask.Common.Result;
using Mindbox.PracticalTask.Shapes.Shape;

namespace Mindbox.PracticalTask.Shapes.Triangle;

public class Triangle : IShape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    
    
    public MbResult<double> CalculateArea()
    {
        var validateResult = Validate();
        if (validateResult.IsNotCorrect)
            return validateResult.Error;
        
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public MbResult<bool> IsRightAngled()
    {
        var validateResult = Validate();
        if (validateResult.IsNotCorrect)
            return validateResult.Error;

        var maxSide = Math.Max(A, Math.Max(B, C));
        var sumOfSquares = (A * A + B * B + C * C) - (maxSide * maxSide);
        return Math.Abs(maxSide * maxSide - sumOfSquares) < 1e-10;
    }

    public MbResult Validate()
    {
        if (A + B <= C || A + C <= B || B + C <= A)
            return new MbError {Code = MbErrorCodes.InvalidParams, Message = "Стороны не могут образовать треугольник"};
        
        if (A <= 0 || B <= 0 || C <= 0)
            return new MbError {Code = MbErrorCodes.InvalidParams, Message = "Размеры сторон не могут быть отрицательными или равны нулю"};

        return MbErrorCodes.Ok;
    }
}