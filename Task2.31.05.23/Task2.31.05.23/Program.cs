using System;
using Task2._31._05._23;

class Program
{
    static void Main(string[] args)
    {
        string fullName;
        string groupNum;
        int age;

        do
        {
            Console.Write("Enter full name: ");
            fullName = Console.ReadLine();
        } while (!Student.CheckFullName(fullName));

        do
        {
            Console.Write("Enter group number (ex, P216): ");
            groupNum = Console.ReadLine();
        } while (!Student.CheckGroupNum(groupNum));

        Console.Write("Enter age: ");
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid input. Please enter a valid well.");
            Console.Write("Enter age: ");
        }


        Student student = new Student
        {
            FullName = fullName,
            GroupNum = groupNum,
            Age = age
        };


        Console.WriteLine("\nStudent Information:");
        Console.WriteLine("Full Name: " + student.FullName);
        Console.WriteLine("Group Num: " + student.GroupNum);
        Console.WriteLine("Age: " + student.Age);
    }
}
