using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Group
    {
        public string Name;
        public int studentCount;
        public List<Student> students = new List<Student>();

        public void AddStuden(Student telebe)
        {
            students.Add(telebe);
        }

        public List<Student> Filter(bool? isWaranted, int? age, int? nameLength)
        {

            return students.FindAll((student) =>
            {
                if(student ==null)
                {
                    return false;
                }

                bool isFiltered = true;

                if( isWaranted !=null && student.isWaranted != isWaranted)
                {
                    return false;

                    //isFiltered = false;
                }

                if (age !=null && student.age <= age)
                {
                    return false;

                    // isFiltered = false;

                }

                if (nameLength !=null && student.Fullname.Length < nameLength)
                {
                    return false;
                    // isFiltered = false;
                }






                return true;
            });
        }
    }
}
