using System.ComponentModel;
using System.Reflection;

namespace Mindbox.PracticalTask.Common.ErrorCodes;

public enum MbErrorCodes
{
    [Description("Успех!")]
    Ok = 1,
    [Description("Неверные параметры!")]
    InvalidParams = 2,
    [Description("Упс...Что-то пошло не так")]
    UnknownError = 3
}

public static class ErrorCodesExtensions
{
    public static string ToFriendlyString(this MbErrorCodes code) 
    {
        string description = code.ToString();
        FieldInfo field = code.GetType().GetField(code.ToString());
        if (field != (FieldInfo) null)
        {
            object[] customAttributes = field.GetCustomAttributes(typeof (DescriptionAttribute), true);
            if (customAttributes != null && customAttributes.Length != 0)
                description = ((DescriptionAttribute) customAttributes[0]).Description;
        }
        return description;
    }
}