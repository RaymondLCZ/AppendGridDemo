using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppendGridWeb.Models
{
    public class Student
    {
        public int No { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Category Category { get; set; }
        public string City { get; set; }
        public string Address { get; set; }


        public static List<Student> List()
        {
            List<Student> students = new List<Models.Student>();
            Student raymond = new Student
            {
                No = 1,
                Name = "Raymond",
                RegistrationDate = new DateTime(2016, 6, 1, 9, 0, 0),
                Category = Category.University,
                City = "新北市",
                Address = "板橋區龍泉街56巷2弄27號2樓"
            };

            Student mary = new Student
            {
                No = 2,
                Name = "Mary",
                RegistrationDate = new DateTime(2015, 4, 3, 15, 30, 0),
                Category = Category.SeconderySchool,
                City = "台北市",
                Address = ""
            };

            Student john = new Student
            {
                No = 3,
                Name = "John",
                RegistrationDate = DateTime.Today,
                Category = Category.HighSchool,
                City = "台北市",
                Address = "大安區忠孝東路四段321號14樓"
            };

            Student peter = new Student
            {
                No = 4,
                Name = "Peter",
                RegistrationDate = DateTime.Today,
                Category = Category.University,
                City = "新北市",
                Address = "ABCID"
            };

            Student gary = new Student
            {
                No = 5,
                Name = "Gary",
                RegistrationDate = DateTime.Today,
                Category = Category.HighSchool,
                City = "台北市",
                Address = ""
            };

            students.Add(raymond);
            students.Add(mary);
            students.Add(john);
            students.Add(peter);
            students.Add(gary);
            return students;
        }
    }

    public enum Category
    {
        Empty,
        SeconderySchool,
        HighSchool,
        University
    }
}