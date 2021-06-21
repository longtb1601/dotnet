using System;
using System.Collections.Generic;
using System.Linq;

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
                PhoneNumber = "0946616194",
                IsGraduated = false,
            },
            new Member{
                FirstName = "Hung",
                LastName = "Ngo Quoc",
                Gender = "Male",
                DateOfBirth = new DateTime(1991,3,7),
                BirthPlace = "Hai Phong",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            },
            new Member{
                FirstName = "Van",
                LastName = "Nguyen Cuong",
                Gender = "Male",
                DateOfBirth = new DateTime(1998,3,7),
                BirthPlace = "Ha Noi",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            },
            new Member{
                FirstName = "Hao Nhien",
                LastName = "Thang",
                Gender = "Male",
                DateOfBirth = new DateTime(2020,11,13),
                BirthPlace = "Ha Noi",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            },
            new Member{
                FirstName = "Lan Phuong",
                LastName = "Nguyen",
                Gender = "Female",
                DateOfBirth = new DateTime(1991,8,8),
                BirthPlace = "Ha Noi",
                PhoneNumber = "0946616194",
                IsGraduated = false,
            }
        };
        static void PrintList(List<Member> list) {
            foreach (var member in list) {
                member.Print();
            }
        }

        //BR1
        static void PrintMaleMembers() {
            var list = members.Where(member => member.Gender == "Male").ToList();
            PrintList(list);
        }

        //BR2
        static Member OldestMembers() {
            var oldestMember = members.OrderByDescending(member => member.Age).FirstOrDefault();
            return oldestMember;
        }

        //BR3
        static void PrintFullNames(List<Member> list) {

            var results = list.Select(member => {
                return member.FullName;
            }).ToList();

            Console.WriteLine(string.Join("\n", results));
        }

        //BR4
        static void SplitMembersByYearOfBirth(List<Member> list, int YearOfBirth) {
            List<Member> l1 = members.Where(member => member.DateOfBirth.Year == 2000).ToList();

            Console.WriteLine("List of members who has birth year is 2000:");

            if(l1.Any()) {
                PrintList(l1);
            } else {
                Console.WriteLine("+ Nobody");   
            }

            List<Member> l2 = members.Where(member => member.DateOfBirth.Year < 2000).ToList();

            Console.WriteLine("List of members who has birth year less than 2000:");

            if(l2.Any()) {
                PrintList(l2);
            } else {
                Console.WriteLine("+ Nobody");   
            }

            List<Member> l3 = members.Where(member => member.DateOfBirth.Year > 2000).ToList();

            Console.WriteLine("List of members who has birth year greater than 2000:");

            if(l3.Any()) {
                PrintList(l3);
            } else {
                Console.WriteLine("+ Nobody");   
            }
        }
        
        //BR5
        static void PrintFirstMemberByBirthPlace(List<Member> list, string place) {

            var member = list.FirstOrDefault(member => member.BirthPlace.Equals(place, StringComparison.OrdinalIgnoreCase));

            if(member != null) {
                Console.WriteLine("+ " + member.FullName);
            } else {
                Console.WriteLine("+ Nobody");
            }

        }
        static void Main(string[] args)
        {
            List<String> names = new List<String>();

            #region BR1

            Console.WriteLine("List of members who is Male:");

            PrintMaleMembers();
            #endregion

            Console.WriteLine("================================================================");

            #region BR2

            var oldest = OldestMembers();

            if(oldest != null) {
                Console.WriteLine("The first oldest member is: " + oldest.FullName + "(" + oldest.Age + ")");
            }

            #endregion

            Console.WriteLine("================================================================");

            #region BR3

            Console.WriteLine("New list that contains Full Name only");   

            PrintFullNames(members);

            #endregion

            Console.WriteLine("================================================================");

            #region BR4

            SplitMembersByYearOfBirth(members, 2000);

            #endregion

            Console.WriteLine("================================================================");
        
            #region BR5

                Console.WriteLine("First person who was born in Ha Noi is:"); 

                PrintFirstMemberByBirthPlace(members, "Ha Noi");

            #endregion
        }
    }
}
