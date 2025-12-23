using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            StudentBL bl = new StudentBL();
            bl.AcceptStudentDetails();
            bl.DisplayResult();
        }
        catch (InvalidMarksException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format");
        }
    }
}