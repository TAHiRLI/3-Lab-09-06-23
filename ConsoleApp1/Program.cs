

namespace ConsoleApp1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Course code = new Course();
            code.Name = "Code";

         


            Group P235 = new Group();



            Student ferid = new Student();
            Student tahir = new Student();

            ferid.Fullname = "Ferid hadizade";
            tahir.Fullname = "Tahir Tahirli";



            P235.AddStuden(ferid);
            P235.AddStuden(tahir);


            


        }

        static void Search(Group group)
        {
            bool? isWaranted = null;
            int? nameLength = null;
            int? age = null;

            // get data from console

            age = 123;

         var students = group.Filter(isWaranted, age, nameLength);

            foreach (var stud in students)
            {
                Console.WriteLine($"Name = {stud.Fullname} ;  Age = {stud.age}");
            }
        }
    }
}
