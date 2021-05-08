using System;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;


namespace Reestr
{
    class Import
    {

        public Department ImportJson(string pathImportFile)
        {
            try
            {
                Console.Write("Enter import file's name: ");
                var importFileName = Console.ReadLine();
                string jsonString = File.ReadAllText(pathImportFile + $"\\{importFileName}.json");
                Department importDepartment = JsonSerializer.Deserialize<Department>(jsonString);

                Console.WriteLine("Complited");

                return importDepartment;
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found. Outputting default data");
                string jsonString = File.ReadAllText(pathImportFile + $"\\JnewReestr.json");
                Department importDepartment = JsonSerializer.Deserialize<Department>(jsonString);

                Console.WriteLine("Complited");

                return importDepartment;
            }
        }
        public Department ImportXml(string pathImportFile)
        {
            try
            {
                Console.Write("Enter import file's name: ");
                var importFileName = Console.ReadLine();
                Department importDepartment = new Department();
                using (FileStream fs = new FileStream(pathImportFile + $"\\{importFileName}.xml", FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlFormatter = new XmlSerializer(typeof(Department));
                    importDepartment = (Department)xmlFormatter.Deserialize(fs);                    
                }

                Console.WriteLine("Complited");

                return importDepartment;
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found. Outputting default data");
                Department importDepartment = new Department();
                using (FileStream fs = new FileStream(pathImportFile + $"\\XMLnewReestr.xml", FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlFormatter = new XmlSerializer(typeof(Department));
                    importDepartment = (Department)xmlFormatter.Deserialize(fs);
                }

                Console.WriteLine("Complited");

                return importDepartment;
            }
        }
        public Department DefaultImportJson(string pathImportFile)
        {
            try
            {
                string jsonString = File.ReadAllText(pathImportFile + "\\JnewReestr.json");
                Department importDepartment = JsonSerializer.Deserialize<Department>(jsonString);

                Console.WriteLine("Complited");

                return importDepartment;
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found. Outputting random data");
                AutoFillingDepartments fill = new AutoFillingDepartments();
                Department company = fill.Fill(); //automatic addition of the departments
                return company;
            }
        }
    }
}
