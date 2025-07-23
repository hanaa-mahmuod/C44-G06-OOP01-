using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.UserDefinedDataTypes
{
    internal class ClassB:ClassA
    {
       public ClassB() {

            age = 30; //accessible because age is protected in ClassA
                   //   name = "Hello World"; //cannot access name because it is private in ClassA
        }
    }
}
