using System;
using System.Collections.Generic;
using System.Text;

namespace DataSTR
{
    class CustomDataList
    {
        public List<Student> studentInfo;
        public int length;
        public Student first;
        public Student last;
        public CustomDataList(List<Student> studentInfo)
        {
            this.studentInfo = studentInfo;
            length = studentInfo.Count;
        }

        public void Add(Student student)
        {
            length += 1;
            studentInfo.Add(student);
            first = studentInfo[0];
            last = student;
        }

        public void GetElement(int index)
        {
            Console.WriteLine(studentInfo[index]);
        }
        public void RemoveByIndex(int index)
        {
            if (index == 0)
            {
                first = studentInfo[1];
            }
            else
            {
                if (index == length - 1)
                {
                    last = studentInfo[length - 2];
                }
            }
            length--;
            studentInfo.RemoveAt(index);
        }

        public void RemoveFirst()
        {
            first = studentInfo[1];
            studentInfo.RemoveAt(1);
            length--;
        }

        public void RemoveLast()
        {
            last = studentInfo[length - 2];
            studentInfo.RemoveAt(length - 1);
            length--;
        }
        public void DisplayList()
        {
            for (int i = 0; i < length; i++)
            {
                GetElement(i);
            }
        }

        public void GetMaxElement()
        {
            Student getMaxScore = studentInfo[0];
            for (int i = 1; i < length; i++)
            {
                if (studentInfo[i].averageScore > getMaxScore.averageScore)
                {
                    getMaxScore = studentInfo[i];
                }
            }
            Console.WriteLine(getMaxScore);
        }
        public void GetMinElement()
        {
            Student getMinScore = studentInfo[0];
            for (int i = 1; i < length; i++)
            {
                if (studentInfo[i].averageScore < getMinScore.averageScore)
                {
                    getMinScore = studentInfo[i];
                }
            }
            Console.WriteLine(getMinScore);
        }

        public void sort()
        {
            Student student = studentInfo[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (studentInfo[j].averageScore < studentInfo[j + 1].averageScore)
                    {
                        student = studentInfo[j];
                        studentInfo[j] = studentInfo[j + 1];
                        studentInfo[j + 1] = student;
                    }



                }
            }
            DisplayList();
        }
      
    }
    
}
