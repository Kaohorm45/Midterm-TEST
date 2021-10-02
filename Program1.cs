using System;
using System.Collections.Generic;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Register kittinun = new Register("kittinun","1234",1);
            kittinun.userName = "kittinun";
            kittinun.code = "1234";
            kittinun.type = 1;
            Console.WriteLine("input Name:" + kittinun.userName);
            Console.WriteLine("input Passcode:" + kittinun.code);
            Console.WriteLine("input type:" + kittinun.type);

            List<Book> books = new List<Book>();
            Book NOWIUNDERSTAND = new Book(1, "NOW I UNDERSTAND");
            Book REVORUTIONARYWEALTH = new Book(2, "REVORUTIONARY WEALTH");
            Book SIXDEGREE = new Book(3, "SIX DEGREE");
            Book LESVACANCES = new Book(4, "LES VACANES");
            books.Add(NOWIUNDERSTAND);
            books.Add(REVORUTIONARYWEALTH);
            books.Add(SIXDEGREE);
            books.Add(NOWIUNDERSTAND);
        }

    }
    class Register
    {
        public string userName;
        public string code;
        public int type;
        public int studentID;
        public int employeeID;

        public Register( string valueUsername , string valueCode , int valueType)
        {
            userName = valueUsername;
            code = valueCode;
            type = valueType;

            if(type == 1)
            {
                Console.WriteLine("Student");
                Console.WriteLine("Student ID: "+studentID);
            } if(type == 2)
            {
                Console.WriteLine("Employee");
                Console.WriteLine("Employee ID: " + employeeID);
            }
            else
            {
                Console.WriteLine("Not found . please try again");
            }
        
        }
    }
    class Book
    {
        public int  Id;
        public string name;

        public Book(int valueID , string valueName)
        {
            Id = valueID;
            name = valueName;
        }
}
    class EmployeeManagement
    {
        public string name;
        public int employeeID;

        public EmployeeManagement(string valueName , int valueEmployeeid)
        {
            name = valueName;
            employeeID = valueEmployeeid;
        }
    }
    class StudentManagement
    {
        public string name;
        public int studentID;

        public StudentManagement(string valueName, int valueStudentid)
        {
            name = valueName;
            studentID = valueStudentid;
        }


    }
}
