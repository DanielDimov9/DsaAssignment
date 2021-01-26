using System;
using System.Collections.Generic;
using System.Text;

namespace DataSTR
{
   public class Student
    {
        private string firstName;
        private string lastName;
        private string studentNumber;
        public float averageScore;

        public Student(string firstName,string lastName,string studentNumber,float averageScore)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;
            this.averageScore = averageScore;

        }
       

        public override string ToString()
        {
            return $"Student: {studentNumber,-10} {firstName,-10} {lastName,-10} Average score = {averageScore:0.00}";
        }
    }
}
