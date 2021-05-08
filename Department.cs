using System;
using System.Collections.Generic;


namespace Reestr
{
    public class Department
    {
        public List<Department> Departments { get; set; }
        public List<Worker> Workers { get; set; }
        public string DepartmentName { get; set; }
        public DateTime CreateDate { get; set;}
        private int CountWorkers { get { return Workers.Count; } }

        public Department(string departmentName)
        {
            this.DepartmentName = departmentName;
            this.CreateDate = DateTime.Now;
            this.Workers = new List<Worker>();
        }
        public Department()
        {
            Departments = new List<Department>();
        }

        public string Print()
        {
            return $"Name of the department: {this.DepartmentName,5} Create date: {this.CreateDate,5} Count of employees: {this.CountWorkers,5}";            
        }

    }
}
