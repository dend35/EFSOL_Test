﻿using Test.Model.Base;

 namespace Test.Model
{
    public class UserData : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        
        public int Age { get; set; }
        
        
    }
}