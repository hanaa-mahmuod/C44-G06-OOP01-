using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.UserDefinedDataTypes
{
    [Flags]
    internal enum Permetion:byte
    {
        read,
        write,
        execute,
        delete,
        // you can combine multiple values using bitwise OR
    }
}
