using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string filePath = "data.xml";
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(filePath);

        XmlNodeList nodeList = xmlDoc.GetElementsByTagName("student");
        foreach (XmlNode node in nodeList)
        {
            Console.WriteLine($"Name: {node["name"].InnerText}, Age: {node["age"].InnerText}");
        }
    }
}
