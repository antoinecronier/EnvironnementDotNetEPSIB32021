using ConsoleApp1.Inheritance;
using ConsoleApp1.Serilization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();
            NewMethod1();
            NewMethod2();

            //serialize<Data>(new Data()
            //{
            //    MyProperty = 10,
            //    MyProperty1 = "bonjour",
            //    MyProperty2 = true,
            //    MyProperty3 = 236548
            //});

            string data = "<?xml version=\"1.0\" encoding=\"utf - 8\"?>" +
                "<Data xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                    "<MyProperty>10</MyProperty>" +
                    "<MyProperty1>bonjour</MyProperty1>" +
                    "<MyProperty2>true</MyProperty2>" +
                    "<MyProperty3>236548</MyProperty3>" +
                "</Data>";

            Data objData = deserialize<Data>(data);

            Console.ReadKey();
        }

        public static void serialize<T>(Object obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
            {
                serializer.Serialize(writer, obj);
                writer.AutoFlush = true;
                Console.SetOut(writer);
            }
        }

        public static T deserialize<T>(String flux)
        {
            byte[] byteArray = Encoding.ASCII.GetBytes(flux);
            MemoryStream stream = new MemoryStream(byteArray);

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            T data = default(T);

            using (StreamReader reader = new StreamReader(stream))
            {
                data = (T)serializer.Deserialize(reader);
            }

            Console.WriteLine(data);
            return data;
        }

        private static void NewMethod2()
        {
            ClassA a = new ClassB();
            ClassB b = new ClassB();

            a.Data = "test";
            (a as ClassB).Data = "test2";

            Console.WriteLine(a.Data);
            Console.WriteLine((a as ClassB).Data);

            a.Test1();
            a.Test2();
            (a as ClassB).Test1();
            (a as ClassB).Test2();
        }

        private static void NewMethod1()
        {
            Class1 c1 = new Class1();
            c1.Firstname = "Are";
            string test = c1.Lastname;
        }

        private static void NewMethod()
        {
            Console.WriteLine("hello world");
            Debug.WriteLine("Debug trace");

            int a = 5;
            bool b = true;
            long c = 5;
            float d = 10.5f;
            double e = 20.20;
            string f = "test";

            int? a1 = 10; //Int32
            bool? b1 = null;
            long? c1;
            float? d1;
            double? e1;
            //string? f1;

            if (a1.HasValue)
            {
                a = a1.Value;
            }

            int test1 = 0;
            int.TryParse("10", out test1);

            if (false)
            {

            }
            else if (true)
            {

            }
            else
            {

            }

            //while (true)
            //{

            //}

            //for (int i = 0; i < length; i++)
            //{

            //}

            //foreach (var item in collection)
            //{

            //}
        }
    }
}
