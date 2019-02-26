using System;
using System.Collections.Generic;
using System.Linq;


namespace Linq
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            
            students.Add(new Student("Chris", "123-456-7891", "123 Delany", -2990));
            students.Add(new Student("Kevin", "512-222-2222", "435 Carolyn", -2500));
            students.Add(new Student("Victoria", "512-827-8498", "701 Brazos St", 0));
            students.Add(new Student("Luke", "555-555-5555", "451 Brody Ln", -500));
           

            IEnumerable<Student> negativeBalance = from currentStudent in students
            where currentStudent.Balance < 0
            select currentStudent;

            Console.WriteLine("All the students with a negative balance");
            foreach(Student currentStudent in negativeBalance)
            {
                Console.WriteLine(currentStudent.Name);
            }

        }
    }
    public class Student 
    {
        public string Name {get; set;}
        public string Phone {get; set;}
        public string Address {get; set;}
        public int Balance {get; set;}
        
        public Student(string name, string phone, string address , int balance)
        {

            Name = name;
            Phone = phone;
            Address = address;
            Balance = balance;
        }
    }
}