using System;
using System.Collections.Generic;


namespace dotnet
{
    class Program
    {
        static List<Member> members = new List<Member>{
            new Member{
                FirstName = "Long",
                LastName = "Bao",
                Gender = "Male",
                DateOfBirth = new DateTime(1994,1,16),
                BirthPlace = "Bac Ninh",
                phoneNumber = "0946616194",
                Age = 27,
                IsGraduated = false,
            },
            new Member{
                FirstName = "Hung",
                LastName = "Ngo Quoc",
                Gender = "Male",
                DateOfBirth = new DateTime(1991,3,7),
                BirthPlace = "Hai Phong",
                phoneNumber = "0946616194",
                Age = 30,
                IsGraduated = false,
            },
            new Member{
                FirstName = "Van",
                LastName = "Nguyen Cuong",
                Gender = "Male",
                DateOfBirth = new DateTime(1998,3,7),
                BirthPlace = "Ha Noi",
                phoneNumber = "0946616194",
                Age = 23,
                IsGraduated = false,
            },
            new Member{
                FirstName = "Hao Nhien",
                LastName = "Thang",
                Gender = "Male",
                DateOfBirth = new DateTime(2020,11,13),
                BirthPlace = "Ha Noi",
                phoneNumber = "0946616194",
                Age = 1,
                IsGraduated = false,
            },
            new Member{
                FirstName = "Lan Phuong",
                LastName = "Nguyen",
                Gender = "Female",
                DateOfBirth = new DateTime(1991,8,8),
                BirthPlace = "Ha Noi",
                phoneNumber = "0946616194",
                Age = 27,
                IsGraduated = false,
            }
        };
        static void Main(string[] args)
        {
            List<String> names = new List<String>();

            #region BR1

            Console.WriteLine("List of members who is Male:");

            for(int i = 0; i < members.Count; i++) {

                Member member = members[i];

                if(member.Gender == "Male") {
                    Console.WriteLine("+ " + member.FullName + "(" + member.Age + ")");
                }
            }

            #endregion

            Console.WriteLine("================================================================");

            #region BR2

            Member oldest = members[0];

            for(int i = 1; i < members.Count; i++) {

                Member member = members[i];

                if(oldest.Age < member.Age) {
                    oldest = member;
                }
            }

            Console.WriteLine("The first oldest member is: " + oldest.FullName + "(" + oldest.Age + ")");

            #endregion

            Console.WriteLine("================================================================");

            #region BR3

            for(int i = 0; i < members.Count; i++) {

                Member member = members[i];
                
                names.Add(member.FullName);

            }

            Console.WriteLine("New list that contains Full Name only");

            foreach (string name in names) {
                Console.WriteLine("+ " + name);
            }

            #endregion

            Console.WriteLine("================================================================");

            #region BR4

            List<Member> l1 = new List<Member>();
            List<Member> l2 = new List<Member>();
            List<Member> l3 = new List<Member>();

            foreach(var member in members) {
                var value = member.DateOfBirth.Year;
                
                switch(value) {
                    case 2000:
                        l1.Add(member);
                        break;
                    default:
                        if(value > 2000) {
                            l2.Add(member);
                        }

                        if(value < 2000) {
                            l3.Add(member);
                        }
                        break;
                }
            }

            Console.WriteLine("List of members who has birth year is 2000:");

            if(l1.Count > 0) {

                foreach(var member in l1) {
                    Console.WriteLine("+ " + member.FullName + "(" + member.DateOfBirth.Year + ")");
                }

            } else {

                Console.WriteLine("+ Nobody");

            }

            Console.WriteLine("List of members who has birth year greater than 2000:");

            if(l2.Count > 0) {

                foreach(var member in l2) {
                    Console.WriteLine("+ " + member.FullName + "(" + member.DateOfBirth.Year + ")");
                }

            } else {

                Console.WriteLine("+ Nobody");

            }

            Console.WriteLine("List of members who has birth year less than 2000:");

            if(l3.Count > 0) {

                foreach(var member in l3) {
                    Console.WriteLine("+ " + member.FullName + "(" + member.DateOfBirth.Year + ")");
                }

            } else {

                Console.WriteLine("+ Nobody");

            }

            #endregion

            Console.WriteLine("================================================================");
        
            #region BR5

                Console.WriteLine("First person who was born in Ha Noi is:"); 

                int index = 0;

                while(true) {
                    var member = members[index];

                    if(member.BirthPlace.Equals("Ha Noi", StringComparison.OrdinalIgnoreCase)) {
                        Console.WriteLine("+ " + member.FullName);
                        break;
                    }

                    if(index > members.Count) {
                        Console.WriteLine("+ Nobody");
                        break;
                    }
                    
                    index++;
                }

            #endregion
        }
    }
}
