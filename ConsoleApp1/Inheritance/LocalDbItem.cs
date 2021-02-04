using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    class LocalDbItem : DbItem
    {
        private long id;

        public new long Id
        {
            get { return id; }
            set { id = value; }
        }

        private Image image;

        public new Image Image
        {
            get { return image; }
            set { 
                //(this as DbItem).Image
                image = value; 
            }
        }

    }
}
