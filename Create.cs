using System;

namespace Reestr
{
    class Create
    {

        public Department CreateNewDepartment(byte byteEnterMode, Department company)
        {
            company.Departments.Add(new Department(Enter.EnterStringData(byteEnterMode)));            
            return company;
        }
public Department CreateNewWorker(Department company)
        {            
            Found found = new Found();

            var foundDepartment = found.FoundDepartament(company);
            Console.WriteLine("Select a department to create an employee");
            foreach (var department in company.Departments)
            {
                Console.WriteLine(department.Print());
            }
                        company.Departments[foundDepartment].Workers.Add(
                    new Worker(
                        Enter.EnterIntData(2), //ID
                        Enter.EnterStringData(6), //firstname
                        Enter.EnterStringData(3), //surname
                        Convert.ToByte(Enter.EnterIntData(7)), //age
                        $"Dep_{company.Departments[foundDepartment].DepartmentName}", //departmentName
                        Enter.EnterStringData(4), //position
                        Enter.EnterIntData(5) //salary
                    ));                
              
            return company;
        }
    }
}
