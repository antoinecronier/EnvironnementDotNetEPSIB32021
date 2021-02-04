using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    abstract class ClassA
    {
        private long id;
        private string data;

        public long Id { get => this.id; set => this.id = value; }
        public string Data { get => this.data; set => this.data = value; }

        public abstract void Test1();
        public virtual void Test2()
        {
            Debug.WriteLine("ClassA - Test2");
        }
    }
}
