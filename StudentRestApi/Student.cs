﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace StudentRestApi
{
    public class Student
    {

        public int StudentId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string email { get; set; }
       /* public Gender Gender { get; set; }*/

        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
    }
}
