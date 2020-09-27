using System.ComponentModel;

namespace Test.Enum
{
    public enum Gender
    {
        [Description("Мужской")] 
        Male,
        
        [Description("Женский")] 
        Female,
        
        [Description("Не указано")] 
        None
    }
}