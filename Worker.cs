

namespace Reestr
{
    public struct Worker
    {
        public int ID { get; set; }
        public string FirstName { get; }
        public string SurName { get; set; }
        public byte Age { get;  }
        public string Department { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public Worker(int id, string firstName, string surName, byte age, string department, string position, int salary)         
        {
            this.ID = id;
            this.FirstName = firstName;
            this.SurName = surName;
            this.Age = age;
            this.Department = department;
            this.Position = position;
            this.Salary = salary;
        }

        public string Print()
        {
           return $"ID: {this.ID,5} Firstname: {this.FirstName,5} Surname: {this.SurName,5} Age: {this.Age,5} Department: {this.Department,5} Position: {this.Position,5} Salary: {this.Salary,5}";
        }

        

    }
}
