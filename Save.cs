using System;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;


namespace Reestr
{
    class Save
    {
        public void SaveXml(string pathToOwnerFile, Department company)
        {           
            XmlSerializer xmlFormatterDepartament = new XmlSerializer(typeof(Department));
            Console.Write("Enter file's name: ");
            string fileName = Console.ReadLine();
            using (FileStream fs = new FileStream(pathToOwnerFile + $"\\{fileName}.xml", FileMode.OpenOrCreate))
            {                
                    xmlFormatterDepartament.Serialize(fs, company);                               
            }
            Console.WriteLine("Save XML Complited");            
        }
        public async void SaveJson(string pathToOwnerFile, Department company)
        {
            Console.Write("Enter file's name: ");
            string fileName = Console.ReadLine();
            using (FileStream fs = new FileStream(pathToOwnerFile+ $"{fileName}.json", FileMode.Create))
            {
                await JsonSerializer.SerializeAsync<Department>(fs, company, new JsonSerializerOptions { WriteIndented = true });               
                Console.WriteLine("Data has been saved to file");
            }            

            Console.WriteLine("Save Json Complited");
        }
    }
}
