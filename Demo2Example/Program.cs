using System;
using Demo2Example;
public class Program
{
    public static void Main(String[] args)
    {
        EmployeeAttendece employee = new EmployeeAttendece();
        employee.DisplayAttendence();
        Console.WriteLine("Enter the Employee Performance");
        string performane=Console.ReadLine();
        Console.WriteLine("result"+performane);
        Console.WriteLine("Enter the Employee Rank");
        int rank =Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Rank is:" + rank);
    }
}