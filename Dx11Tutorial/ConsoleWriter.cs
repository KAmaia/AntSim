using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dx11Tutorial
{
    class ConsoleWriter
    {
        public void Write(String msg)
        {
            Console.Out.Write(msg);
        }
        public void WriteLine(String msg)
        {
            Console.Out.WriteLine(msg);
        }
    }
}
