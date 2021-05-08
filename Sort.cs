using System;
using System.Linq;

namespace Reestr
{
    class Sort
    {        
        public void SortOnlyAge(Department company)
        {            
           var workers = company.Departments.SelectMany(w => w.Workers);
           
            Console.WriteLine("The result of sorting employees only by age in all departments:");
            var result = workers.OrderBy(x => x.Age);
            foreach (var worker in result)
            {
                Console.WriteLine(worker.Print());
            }
        }
        public void SortAgeAndSalary(Department company)
        {               
            var workers = company.Departments.SelectMany(workers => workers.Workers);

            Console.WriteLine("The result of sorting employees by age and salary in all departments:");
            var result = workers.OrderBy(x => x.Age).ThenBy(x => x.Salary);
            foreach (var worker in result)
            {
                Console.WriteLine(worker.Print());
            }
        }
        public void SortAgeAndSalaryInEachDepartment(Department company)
        {
            Console.WriteLine("The result of sorting employees only by age and salary in each department:");
            foreach (var department in company.Departments)
            {                
                var result = department.Workers.OrderBy(x => x.Age).ThenBy(x => x.Salary).ToList();
                foreach (var worker in result)
                {
                    Console.WriteLine(worker.Print());
                }
            }
        }
    }
}
