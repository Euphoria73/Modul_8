using System;
using System.Collections.Generic;
using System.Text;

namespace Reestr
{
    class AutoFillingDepartments
    {
        public Department Fill()
        {
            Random random = new Random();

            Department company = new Department
            {
                Departments = new List<Department>()
                {
                new Department { DepartmentName = "HR", CreateDate = DateTime.Now, Workers = new List<Worker>() },
                new Department { DepartmentName = "Legal", CreateDate = DateTime.Now, Workers = new List<Worker>() },
                }
            };

            foreach (var department in company.Departments)
            {
                for (int j = 0; j < 5; j++)
                {
                    department.Workers.Add(
                    new Worker(
                        j + 1,
                        $"Имя_{j + 1}",
                        $"Фамилия_{j + 1}",
                        (byte)random.Next(18, 20),
                        $"Отдел_{department.DepartmentName}",
                        $"Должность_{j + 1}",
                        (int)random.Next(10000, 80000)
                    ));
                }
            }
            return company;
        }
    }
}
