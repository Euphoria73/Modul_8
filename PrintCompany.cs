using System;


namespace Reestr
{
    class PrintCompany
    {
        public static void PrintDepartment(Department company)
        {
            foreach (var department in company.Departments)
            {        
                Console.WriteLine(department.Print());

                foreach (var worker in department.Workers)
                {
                    Console.WriteLine(worker.Print());
                }
            }
        }
    }
}
