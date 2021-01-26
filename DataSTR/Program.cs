using System;
using System.Collections.Generic;

namespace DataSTR
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Ivan", "Ivanov", "1", 28);
            Student st1 = new Student("Jordan", "Kirilov", "2", 36);
            Student st2 = new Student("Dimitar", "Ivanov", "3", 87);
            Student st3 = new Student("Mario", "Ivanov", "4", 66);
            Student st4 = new Student("Kiril", "Malev", "6", 54);
            List<Student> studentData = new List<Student>();
            CustomDataList Data = new CustomDataList(studentData);
            Data.Add(st);
            Data.Add(st1);
            Data.Add(st2);
            Data.Add(st3);
            Data.Add(st4);

            while (true)
            {
                Console.Clear();

                Console.WriteLine("=====================================================");

                Console.WriteLine(" MENU ");

                Console.WriteLine("=====================================================");
                Console.WriteLine("1.Add student :");
                Console.WriteLine("2.Get element");
                Console.WriteLine("3.Remove element");
                Console.WriteLine("4.Display students");
                Console.WriteLine("5.Get max score");
                Console.WriteLine("6.Get min score");
                Console.WriteLine("7.Sort");

                string result = Console.ReadLine();
                switch (result)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("First name : ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Last name : ");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Student ID : ");
                        string studentNumber = Console.ReadLine();
                        Console.WriteLine("Average score : ");
                        float averageScore = float.Parse(Console.ReadLine());
                        Student newStudent = new Student(firstName, lastName, studentNumber, averageScore);
                        Data.Add(newStudent);
                        Console.WriteLine();
                        Console.WriteLine("New");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;


                    case "2":
                        Console.Clear();
                        Console.WriteLine("Please enter an index");
                        int index = Convert.ToInt32(Console.ReadLine());
                        while (index < 0 || index >= Data.length)
                        {
                            Console.Clear();
                            Console.WriteLine("Error,try again");
                            index = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Clear();
                        Data.GetElement(index);
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("What need to be removed");
                        Console.WriteLine("1. Remove with an index");
                        Console.WriteLine("2. Remove the first element");
                        Console.WriteLine("3. Remove the last element");
                        Console.WriteLine("4. Return to the main menu");
                        string newResult = Console.ReadLine();
                        switch (newResult)
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Please enter an index");
                                int index1 = Convert.ToInt32(Console.ReadLine());
                                while (index1 < 0 || index1 >= Data.length)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Error,try again");
                                    index1 = Convert.ToInt32(Console.ReadLine());
                                }
                                Data.RemoveByIndex(index1);
                                Console.Clear();
                                Console.WriteLine(" Deleted");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to return to the menu");
                                Console.ReadKey();
                                break;

                            case "2":
                                Console.Clear();
                                Data.RemoveFirst();
                                Console.WriteLine("First,deleted");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to return to the menu");
                                Console.ReadKey();
                                break;

                            case "3":
                                Console.Clear();
                                Data.RemoveLast();
                                Console.WriteLine("Last item successfully deleted");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to return to the menu");
                                Console.ReadKey();
                                break;

                                ;
                        }
                        break;

                    case "4":
                        Console.Clear();
                        Data.DisplayList();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.Clear();
                        Data.GetMaxElement();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.Clear();
                        Data.GetMinElement();
                        Console.WriteLine();
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine(" Sort");
                        ;
                        string answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "1":
                                Console.Clear();
                                Data.sort();
                                Console.WriteLine();
                                Console.WriteLine("Press any key to return to the menu");
                                Console.ReadKey();
                                break;
                        }
                        break;

                }
               

            }
        }
    }
}

