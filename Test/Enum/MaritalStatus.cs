using System.ComponentModel;

namespace Test.Enum
{
    public enum MaritalStatus
    {
        [Description("Свободен")] 
        Free,
        
        [Description("ТНН")] 
        TNN,
        
        [Description("Люблю кодить")] 
        ILoveCoding,
        
        [Description("Не указано")] 
        None
    }
}