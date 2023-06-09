

namespace ConsoleApp1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Course code = new Course();
            code.Name = "Code";

         


            Group P235 = new Group();
            P235.students = new Student[0];



            Student ferid = new Student();
            Student tahir = new Student();

            ferid.Fullname = "Ferid hadizade";
            tahir.Fullname = "Tahir Tahirli";



            P235.AddStuden(ferid);
            P235.AddStuden(tahir);


            foreach (var stud in P235.students)
            {
                Console.WriteLine(stud.Fullname);
            }


        }
    }
}
