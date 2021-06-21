using System;
public class Member:Person
{
    public int Age { 
        get
        { 
            return CalculateAge();
        }
    }
    private int CalculateAge() {
        TimeSpan ts = DateTime.Now - DateOfBirth;

        DateTime age = DateTime.MinValue.AddDays(ts.Days);

        return age.Year - 1; 
    }
    public bool IsGraduated { get; set; }
    public string FullName { 

        get{
            return $"{LastName} {FirstName}";
        }
        
    }

    public void Print()
    {
        Console.WriteLine($"+ {FullName} ({Age})");
    }
}