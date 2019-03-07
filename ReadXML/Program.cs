using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadXML
{
    class Program
    {
        static void Main(string[] args)
        {
            
            XmlDocument file;
            char c = '\u005c';
            // Cambiar ruta a algun xaml que tengan local ustedes
            String ruta = "C:" + c + "Users" + c + "GQ925VN" + c + "Documents" + c + "UiPath" + c + "ChinoTime" + c + "QA.xaml";
            Console.WriteLine(ruta);
            ReadXML readXML = new ReadXML();
            readXML.Path = ruta;
            readXML.loadXML();
            readXML.readChildNodes();
            Console.ReadLine();
        }
    }
}
