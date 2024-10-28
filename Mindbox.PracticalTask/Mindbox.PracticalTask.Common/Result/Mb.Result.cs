using Mindbox.PracticalTask.Common.Error;
using Mindbox.PracticalTask.Common.ErrorCodes;

namespace Mindbox.PracticalTask.Common.Result;

public class MbResult
{
    public MbError Error { get; set; }
    public bool IsCorrect => Error == null || Error.Code == MbErrorCodes.Ok;
    public bool IsNotCorrect => !IsCorrect;

    public MbResult(MbError error)
    {
        Error = error;
    }
    
    public static implicit operator MbResult(MbErrorCodes errorCode) => new MbResult(MbError.FromCode(errorCode));
    public static implicit operator MbResult(MbError error) => new MbResult(error);
}

public class MbResult<TResult> : MbResult
{
    public TResult Result { get; set; }
    
    public MbResult(MbError error) : base(error)
    {
    }
    
    public MbResult(TResult result) : base(null)
    {
        Result = result;
    }
    
    public static implicit operator MbResult<TResult>(TResult obj) => new(obj);
    public static implicit operator MbResult<TResult>(MbError error) => new MbResult<TResult>(error);
}