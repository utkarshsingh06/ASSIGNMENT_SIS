﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudetnInformationSystem.Models
{
    internal class Teacher
    {
        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Teacher(int teacherID, string firstName, string lastName, string email)
        {
            TeacherID = teacherID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Teacher()
        {
        }

        public override string ToString()
        {
            return $"TeacherID: {TeacherID}, FirstName: {FirstName}, LastName: {LastName}, Email: {Email}";
        }
    }
}
