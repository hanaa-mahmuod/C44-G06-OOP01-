using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.UserDefinedDataTypes
{

    internal class ClassA
    {
        private string name;
        //only accessible within the class
        protected int age;
        //only accessible within the class and classes that inherit from this class what ever assembly they are in(in same or defferint project)
        private protected double salary;
        //accessible within classes that inherit from this class  and in the same assembly
        internal bool isActive;
        //accessible within the same project what ever there are inherited or not
    }
}
