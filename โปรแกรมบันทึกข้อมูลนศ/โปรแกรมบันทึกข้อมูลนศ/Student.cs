using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace โปรแกรมบันทึกข้อมูลนศ_
{
    internal class Student
    {
        public string Name
        { get; set; }
        public string Student_id
        { get; set; }
        public string Birthyear
        { get; set; }
        public string Height
        { get; set; }
        public double Grade
        { get; set; }
        public string Major
        { get; set; }
        public Student(string name, string student_id, string birthyear, string height, double grade, string Major)
        {
            this.Name = name;
            this.Student_id = student_id;
            this.Birthyear = birthyear;
            this.Height = height;
            this.Grade = grade;
            this.Major = Major;

        }

    }
}

