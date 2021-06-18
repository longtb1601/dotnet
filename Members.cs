using System;
public class Member
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string phoneNumber { get; set; }
    public string BirthPlace { get; set; }
    public int Age { 
        get
        { 
            return DateTime.Now.Year - DateOfBirth.Year;
        }

        set
        {
            int _age = value;
        }
    }
    public bool IsGraduated { get; set; }
    public string FullName { 

        get{
            return FirstName + " " + LastName;
        }
        
    }

}