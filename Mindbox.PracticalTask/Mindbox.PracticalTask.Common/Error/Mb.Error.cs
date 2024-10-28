using Mindbox.PracticalTask.Common.ErrorCodes;

namespace Mindbox.PracticalTask.Common.Error;

public class MbError
{
    public MbError()
    {
    }
        
    public MbError(string message)
    {
        Message = message;
    }
        
    public MbErrorCodes Code { get; set; }
    public string Message { get; set; }
    
    public static MbError FromCode(MbErrorCodes code, string message = null) => new()
        {
            Code = code,
            Message = message ?? code.ToFriendlyString()
        };
}