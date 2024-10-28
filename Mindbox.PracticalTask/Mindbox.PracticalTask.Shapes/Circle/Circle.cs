using Mindbox.PracticalTask.Common.Error;
using Mindbox.PracticalTask.Common.ErrorCodes;
using Mindbox.PracticalTask.Common.Result;
using Mindbox.PracticalTask.Shapes.Shape;

namespace Mindbox.PracticalTask.Shapes.Circle;

public class Circle : IShape
{
    public double Radius { get; set; }
    
    public MbResult<double> CalculateArea()
    {
        var validateResult = Validate();
        if (validateResult.IsNotCorrect)
            return validateResult.Error;
        
        return Math.PI * Math.Pow(Radius, 2);
    }

    public MbResult Validate()
    {
        if (Radius <= 0)
            return new MbError {Code = MbErrorCodes.InvalidParams, Message = "Радиус неправильный!"};

        return MbErrorCodes.Ok;
    }
}