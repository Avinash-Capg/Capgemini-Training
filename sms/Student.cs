using System;

public class Student
{
    public int RollNo { get; set; }

    private int phy;
    private int chem;
    private int mth;

    public int Phy
    {
        get { return phy; }
        set
        {
            if (value < 0 || value > 100)
                throw new InvalidMarksException("Physics marks must be between 0 and 100");
            phy = value;
        }
    }

    public int Chem
    {
        get { return chem; }
        set
        {
            if (value < 0 || value > 100)
                throw new InvalidMarksException("Chemistry marks must be between 0 and 100");
            chem = value;
        }
    }

    public int Mth
    {
        get { return mth; }
        set
        {
            if (value < 0 || value > 100)
                throw new InvalidMarksException("Maths marks must be between 0 and 100");
            mth = value;
        }
    }

    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
}

public class InvalidMarksException : Exception
{
    public InvalidMarksException(string message) : base(message) { }
}