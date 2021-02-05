﻿using ConsoleApp1.Database;
using ConsoleApp1.Inheritance;
using ConsoleApp1.Serilization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.Entity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            //NewMethod1();
            //NewMethod2();
            //NewMethod3();
            //NewMethod4();
            //NewMethod5();

            using (var db = new BbContext1())
            {
                var first = db.Roles.First(x => x.Id >= 8);
                var firstOrDefault = db.Roles.FirstOrDefault(x => x.Id < -2);
                var single = db.Roles.Single(x => x.Name == "role2");
                var singleOrDefault = db.Roles.SingleOrDefault(x => x.Name.StartsWith("N"));
                var orderBy = db.Roles.OrderBy(x => x.Name);

                foreach (var item in orderBy)
                {
                    Console.WriteLine(item.Name);
                }

                var orderByDescending = db.Roles.OrderByDescending(x => x.Name);

                foreach (var item in orderByDescending)
                {
                    Console.WriteLine(item.Name);
                }

                var min = db.Roles.Min(x => x.Id);
                var max = db.Roles.Max(x => x.Id);
                var average = db.Roles.Average(x => x.Id);
                var sum = db.Roles.Sum(x => x.Id);
                var count = db.Roles.Count();
                var where = db.Roles.Where(x => x.Id > 5 && x.Id < 15).ToList();

                foreach (var item in where)
                {
                    Console.WriteLine(item.Name);
                }

                var select = db.Roles.Select(x => x.Name);

                foreach (var item in select)
                {
                    Console.WriteLine(item);
                }

                var groupBy = db.Roles.GroupBy(x => x.Name.Contains("r"));
            }

            Console.ReadKey();
        }

        private static void NewMethod5()
        {
            using (var db = new MyBdContext())
            {
                foreach (var item in db.Users.Include(x => x.Roles))
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine(db.Users.Find(3));

                var user = db.Users.Find(4);

                user.Firstname = "bonjour";
                user.Lastname = "antoine";

                db.Entry(user).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();

                var user1 = db.Users.Find(5);

                db.Users.Remove(user1);

                db.SaveChanges();

                foreach (var item in db.Users)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void NewMethod4()
        {
            var ser = serializeJSON(new Data()
            {
                MyProperty = 10,
                MyProperty1 = "bonjour",
                MyProperty2 = true,
                MyProperty3 = 236548
            });

            string data = "{ }";
            var desr = deserializeJSON<Data>(data);
        }

        public static string serializeJSON(Object obj)
        {
            String data = JsonConvert.SerializeObject(obj);
            Console.WriteLine(data);
            return data;
        }

        public static T deserializeJSON<T>(String flux)
        {
            T data = JsonConvert.DeserializeObject<T>(flux);
            Console.WriteLine(data);
            return data;
        }

        private static void NewMethod3()
        {
            var d21 = new Data2()
            {
                MyProperty = 10,
                MyProperty1 = "bonjour",
                MyProperty2 = true,
                MyProperty3 = 236548
            };

            var d22 = new Data2()
            {
                MyProperty = 10,
                MyProperty1 = "bonjour",
                MyProperty2 = true,
                MyProperty3 = 236548
            };

            var d23 = new Data2()
            {
                MyProperty = 10,
                MyProperty1 = "bonjour",
                MyProperty2 = true,
                MyProperty3 = 236548
            };

            d23.Datas.Add(d21);
            d23.Datas.Add(d22);

            serializeXML<Data2>(d23);

            string data = "<?xml version=\"1.0\" encoding=\"utf - 8\"?>" +
                "<Data xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                    "<MyProperty>10</MyProperty>" +
                    "<MyProperty1>bonjour</MyProperty1>" +
                    "<MyProperty2>true</MyProperty2>" +
                    "<MyProperty3>236548</MyProperty3>" +
                "</Data>";

            Data objData = deserializeXML<Data>(data);
        }

        public static void serializeXML<T>(Object obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamWriter writer = new StreamWriter(Console.OpenStandardOutput()))
            {
                serializer.Serialize(writer, obj);
                writer.AutoFlush = true;
                Console.SetOut(writer);
            }
        }

        public static T deserializeXML<T>(String flux)
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
