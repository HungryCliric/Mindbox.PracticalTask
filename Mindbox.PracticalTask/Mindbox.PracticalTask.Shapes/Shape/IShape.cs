using Mindbox.PracticalTask.Common.Result;

namespace Mindbox.PracticalTask.Shapes.Shape;

public interface IShape
{
    MbResult<double> CalculateArea();
    MbResult Validate();
}