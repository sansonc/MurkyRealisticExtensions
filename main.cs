using System;

class Program
{
    static void Main()
    {
        string name = "Robert Hall";
        DateTime birthdate = new DateTime(1949,2,27);
        string workPhoneNumber = "000-444-0101";
        string cellPhoneNumber = "000-444-0189";

        Console.WriteLine(name);
        Console.WriteLine(birthdate.ToString("MM/dd/yyyy"));
        Console.WriteLine("work " + workPhoneNumber);
        Console.WriteLine("cell " + cellPhoneNumber);
    }
}
