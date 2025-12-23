using System;

public class StudentBL
{
    Student sObj = new Student();

    public void AcceptStudentDetails()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Student Management System");
        Console.WriteLine("==========================");
        Console.ResetColor();

        Console.Write("Enter Your Roll No : ");
        sObj.RollNo = Int32.Parse(Console.ReadLine());

        Console.Write("Enter Your Name : ");
        sObj.Name = Console.ReadLine();

        Console.Write("Enter Your Address : ");
        sObj.Address = Console.ReadLine();

        Console.Write("Enter Physics Marks : ");
        sObj.Phy = Int32.Parse(Console.ReadLine());

        Console.Write("Enter Chemistry Marks : ");
        sObj.Chem = Int32.Parse(Console.ReadLine());

        Console.Write("Enter Maths Marks : ");
        sObj.Mth = Int32.Parse(Console.ReadLine());
    }

    public void DisplayResult()
    {
        int total = sObj.Phy + sObj.Chem + sObj.Mth;
        double percentage = total / 3.0;

        Console.WriteLine("\n----- Student Result -----");
        Console.WriteLine("Roll No    : " + sObj.RollNo);
        Console.WriteLine("Name       : " + sObj.Name);
        Console.WriteLine("Address    : " + sObj.Address);
        Console.WriteLine("Total      : " + total);
        Console.WriteLine("Percentage : " + percentage);
        Console.WriteLine("Status     : " +
            (sObj.Phy >= 40 && sObj.Chem >= 40 && sObj.Mth >= 40 ? "Pass" : "Fail"));
    }
}