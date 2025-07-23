using System.Security;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region q1
            //WeekDayes weekDayes = new WeekDayes();
            //string [] days = Enum.GetNames(typeof(WeekDayes));
            //foreach (string day in days) {
            //    Console.WriteLine(day);
            //}
            #endregion
            #region q4
            //string s=Console.ReadLine();
            //bool isdefined= Enum.IsDefined(typeof(colores), s);
            //if (isdefined)
            //{
            //    Console.WriteLine($"{s} is defined in colores enum.");
            //}
            //else
            //{
            //    Console.WriteLine($"{s} is not defined in colores enum.");
            //}

            #endregion
            #region Q2
        //    string s = Console.ReadLine();
        //    if (Enum.TryParse(s, true, out Seasons season))
        //    {
        //        switch (season)
        //        {
        //            case Seasons.spring:
        //                Console.WriteLine("Spring: March to May");
        //                break;
        //            case Seasons.summer:
        //                Console.WriteLine("Summer: June to August");
        //                break;
        //            case Seasons.autumn:
        //                Console.WriteLine("Autumn: September to November");
        //                break;
        //            case Seasons.winter:
        //                Console.WriteLine("Winter: December to February");
        //                break;
        //            default:
        //                Console.WriteLine("Invalid season.");
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter one of the following: Spring, Summer, Autumn, Winter.");
        //    }
        //} 
        #endregion

        #region q3

        //Permitions permitions =Permitions.Read| Permitions.Write | Permitions.Execute;
            
        //    Console.WriteLine($"User Permissions: {permitions}");

           
        //    if ((permitions & Permitions.Write) == Permitions.Write)
        //    {
        //        Console.WriteLine(" Write permission.");
        //    }

        //    if ((permitions & Permitions.Delete) == Permitions.Delete)
        //    {
        //        Console.WriteLine(" Delete permission.");
        //    }
        //    else
        //    {
        //        Console.WriteLine(" NOT have Delete");
        //    }
            #endregion
        }
    }
}
