

namespace Reestr
{
    class Delete
    {
        readonly Found found = new Found();
        public Department DeleteDepartment(Department company)
        {
            
            var foundWorker = found.FoundDepartament(company);
            company.Departments.RemoveAt(foundWorker);  

            return company;
        }

        public Department DeleteWorker(Department company)
        {
            
            var foundWorker = found.FoundWorker(company);            
            for (int i = 0; i < foundWorker.Count - 1; i++)
            {
                company.Departments[foundWorker[0]].Workers.RemoveAt(foundWorker[i + 1]);                
            }
            return company;
        }
    }
}
