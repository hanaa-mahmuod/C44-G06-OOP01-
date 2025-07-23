using demo.UserDefinedDataTypes;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ClassA objA = new ClassA();
            //  // objA.age = 30; //cannot access protected member 'age' in 'ClassA'
            //  // objA.salary = 50000; //cannot access private protected member 'salary' in 'ClassA'

            #region ex1 for enum
            //  Person person = new Person();
            //  person.Name = "John Doe"; // accessible because Name is public
            //  person.gender = Gender.female;
            #endregion
            #region ex2 for enum
            //bool isparsed;
            //int age;
            //Student student = new Student();
            //do {

            //    Console.WriteLine("Enter your age:");
            //     isparsed=int.TryParse(Console.ReadLine(), out age);
            //    if (!isparsed)
            //    {
            //        Console.WriteLine("enter valid age");
            //    }
            //}
            //while (! isparsed);
            //student.Age = age;

            //int id;
            //do
            //{

            //    Console.WriteLine("Enter your id:");
            //    isparsed = int.TryParse(Console.ReadLine(), out id);
            //    if (!isparsed)
            //    {
            //        Console.WriteLine("enter valid id");
            //    }
            //}
            //while (!isparsed);
            //student.Id = id;


            //Console.WriteLine("enter your name ");
            //student.Name = Console.ReadLine();

            //object grade;
            //do
            //{

            //    Console.WriteLine("Enter your grade:");
            //    isparsed = Enum.TryParse(typeof(Grade), Console.ReadLine(), out grade); 
            //    if (!isparsed)
            //    {
            //        Console.WriteLine("enter valid grade");
            //    }
            //}
            //while (!isparsed);
            //student.Grade = (Grade)grade;




            //object gender;
            //do
            //{

            //    Console.WriteLine("Enter your gender:");
            //    isparsed = Enum.TryParse(typeof(Gender), Console.ReadLine(),true, out gender);
            //    if (!isparsed)
            //    {
            //        Console.WriteLine("enter valid gender");
            //    }
            //}
            //while (!isparsed);
            //student.Gender = (Gender)gender;
            //Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Grade   : {student.Grade},:gender: {student.Gender}");
            #endregion
            #region EX3 IN ENUM
           // User user = new User();

            #endregion

            #region enum methods
            string [] names = Enum.GetNames(typeof(Grade));
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Array values = Enum.GetValues(typeof(Grade));
            foreach (var value in values)
            {
                Console.WriteLine((int)value);
            }


            bool isDefined = Enum.IsDefined(typeof(Grade), "A");
            #endregion

        }
    }
}
