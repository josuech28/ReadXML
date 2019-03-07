using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadXML
{
    class ReadXML
    {
        private XmlDocument document;
        private string path;

        public ReadXML()
        {
            document  = new XmlDocument();
        }

        public string Path {
            get { return path; }
            set { path = value; }
        }

        public XmlDocument Document
        {
            get { return document; }
            set { document = value; }
        }

        public XmlDocument loadXML()
        {
            try
            {
                document.Load(path);
                return document;
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\text.txt", path + "\r\n\r\n" + ex.Message);
                throw ex;
            }
        }

        public XmlNode findNode(string nodePath)
        {
            XmlNode node = document.DocumentElement.SelectSingleNode(nodePath);
            return node;
        }

        public string getNodeText(XmlNode node)
        {
            return node.InnerText;
        }

        public string readAttribute(XmlNode node, string attributeName)
        {
            string attribute = node.Attributes[attributeName]?.InnerText;
            return attribute;
        }

        public void readChildNodes()
        {
            foreach (XmlNode node in document.DocumentElement.ChildNodes)
            {
   
                string nodeContent = node.InnerText;
                string nodeXML = node.Name;
                Console.WriteLine("XML -> " + nodeXML + " Content: " + nodeContent);
                if (node.HasChildNodes)
                {
                    foreach(XmlNode children in node)
                    {
                        nodeContent = children.InnerText;
                        nodeXML = children.Name;
                        Console.WriteLine("XML Children -> " + nodeXML + " Content children: " + nodeContent);
                    }
                }
            }
        }

    }
}
