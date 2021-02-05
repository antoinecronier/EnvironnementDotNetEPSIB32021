using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TP1.Data;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new Tp1DbContext())
            {
                foreach (var item in db.Buys)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();

            using (var db = new Tp1DbContext())
            {
                foreach (var item in db.BookShops.Include(x => x.Books))
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }
}
