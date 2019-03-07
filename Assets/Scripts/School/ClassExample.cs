using System;
namespace RC3Students
{
    public class Student
    {
        //properties
        public string FirstName;
        public string LastName;

        private int age;
        public string homeCountry;

        //Constructor
        public Student(string _FirstName, string _LastName, int _age, string _homeCountry)
        {
            FirstName = _FirstName;
           LastName = _LastName;
            age = _age;
            homeCountry = _homeCountry;

        }
        //functions
        public string GetStudentName()
        {
            return FirstName + LastName;
        }
        public string GetHomeCountry()
        {
            return homeCountry;
        }

        //platonic objects that are nice to put together
        //container        
    }
}