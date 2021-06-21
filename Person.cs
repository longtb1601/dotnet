using System;
public class Person
{
    protected string _firstName;
    public string FirstName { 
        get
        {
            return _firstName;
        }
        set 
        {
            _firstName = value;
        }
    }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public string BirthPlace { get; set; }

}