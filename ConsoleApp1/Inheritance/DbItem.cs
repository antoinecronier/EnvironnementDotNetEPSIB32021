using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    class DbItem
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

    }
}
