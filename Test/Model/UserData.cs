﻿using System;
 using Test.Enum;
 using Test.Model.Base;

 namespace Test.Model
{
    public class UserData : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        
        public int Age { get; set; }

        public Gender Gender { get; set; } = Gender.None;
        
        public DateTime BirthDate { get; set; }

        public MaritalStatus MaritalStatus { get; set; } = MaritalStatus.None;

        public bool Coder { get; set; }
    }
}