using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prg_4A
{
    class Baseclass
    {
        public virtual string city()
        {
            return "BMSCE";
        }
    }
    class derivedclass : Baseclass
    {
        public override string city()
        {
            return "BMSIT";
        }

    }
    class program6
    {
        static void Main(string[] args)
        {
            derivedclass o = new derivedclass();
            string city = o.city();
            Console.WriteLine("college name is {0}", city);
            Console.ReadLine();
        }
    }
}

