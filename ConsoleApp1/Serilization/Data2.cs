using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Serilization
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("base-data")]
    public class Data2
    {
        [System.Xml.Serialization.XmlElement("int")]
        public int MyProperty { get; set; }
        [System.Xml.Serialization.XmlElement("string")]
        public String MyProperty1 { get; set; }
        [System.Xml.Serialization.XmlElement("MyProperty2")]
        public Boolean MyProperty2 { get; set; }
        [System.Xml.Serialization.XmlElement("Int64")]
        public Int64 MyProperty3 { get; set; }

        public List<Data2> Datas { get; set; } = new List<Data2>();
    }
}
