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
        public Student[] students;

        public void AddStuden(Student telebe)
        {
           Array.Resize(ref students, students.Length +1);
            students[students.Length-1] = telebe;
        }
    }
}
