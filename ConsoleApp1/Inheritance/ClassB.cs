using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    class ClassB : ClassA
    {
        private string data;

        public new string Data
        {
            get { return data; }
            set { data = value; }
        }

        public override void Test1()
        {
            Debug.WriteLine("ClassB - Test1");
        }

        public override void Test2()
        {
            Debug.WriteLine("ClassB - Test2");
        }
    }
}
