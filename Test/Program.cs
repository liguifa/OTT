using DAL.lib;
using Data.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Project p = new Project();
            DataTable dt = p.Select();
            Console.WriteLine(dt.Rows[0][0]);
            Console.Read();
        }
    }
}
