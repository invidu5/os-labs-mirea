using System;
using System.IO;
using System.Xml.Linq;

namespace lr1
{
    static class Xml
    {
        private const string Path = "employees.xml";
        public static void Run()
        {
            GenerateXml();

            var doc = XDocument.Load(Path);
            Console.WriteLine("Generated XML:\n");
            Console.WriteLine(doc + "\n");
            
            Console.WriteLine("Please enter information about a new employee.");
            var newEmployee = new XElement("employee");
            newEmployee.Add(new XElement("id", 4));
            Console.Write("1 line: ");
            newEmployee.Add(new XElement("firstName", Console.ReadLine()));
            Console.Write("2 line: ");
            newEmployee.Add(new XElement("lastName", Console.ReadLine()));
            Console.Write("3 line: ");
            newEmployee.Add(new XElement("photo", Console.ReadLine()));

            var root = doc.Element("employees");
            root.Add(newEmployee);
            doc.Save(Path);
            
            Console.WriteLine("\nEdited XML:\n");
            Console.WriteLine(doc + "\n");
            
            File.Delete(Path);
        }

        private static void GenerateXml()
        {            
            var doc = new XDocument();

            var employee1 = new XElement("employee");
            employee1.Add(new XElement("id", 1));
            employee1.Add(new XElement("1 line", ""));
            employee1.Add(new XElement("2 line", ""));
            employee1.Add(new XElement("3 line", ""));
            
            var employee2 = new XElement("employee");
            employee1.Add(new XElement("id", 1));
            employee1.Add(new XElement("", ""));
            employee1.Add(new XElement("", ""));
            employee1.Add(new XElement("", ""));
            
	    var employee3 = new XElement("employee");
            employee1.Add(new XElement("id", 1));
            employee1.Add(new XElement("", ""));
            employee1.Add(new XElement("", ""));
            employee1.Add(new XElement("", ""));
            
            var employees = new XElement("employees");
            employees.Add(employee1, employee2, employee3);
            
            doc.Add(employees);
            doc.Save(Path);
        }
    }
}

