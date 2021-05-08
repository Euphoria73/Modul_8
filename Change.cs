using System;


namespace Reestr
{
    class Change
    {
       readonly Found found = new Found();
        public Department ChangeDepartment(Department company)
        {
            
            var foundDepartment = found.FoundDepartament(company);
            company.Departments[foundDepartment].DepartmentName = $"{Enter.EnterStringData(1)}";
            //update department data for employees
            for (int j = 0; j < company.Departments[foundDepartment].Workers.Count; j++)
            {
                Worker worker = company.Departments[foundDepartment].Workers[j];
                worker.Department = company.Departments[foundDepartment].DepartmentName;
                company.Departments[foundDepartment].Workers[j] = worker;
            }
            return company;
        }
        public Department ChangeWorker(Department company)
        {           
            var foundWorker = found.FoundWorker(company);

            Console.WriteLine("Select what you want change:\n"+
                "WorkerID = 1,"+
                "WorkerSurName = 2," +                
                "WorkerPosition = 3,"+
                "WorkerSalary = 4");
            byte choiseMode = Enter.ChoiseMode();
            
            switch ((EnterDataEnum)choiseMode+1)
            {
                case EnterDataEnum.WorkerID:
                    for (int i = 0; i < foundWorker.Count - 1; i++)
                    {
                        Worker work = company.Departments[foundWorker[0]].Workers[foundWorker[i + 1]];
                        work.ID = Enter.EnterIntData(Convert.ToByte(choiseMode + 1));
                        company.Departments[foundWorker[0]].Workers[foundWorker[i + 1]] = work;
                    }
                    break;
                case EnterDataEnum.WorkerSurName:
                    for (int i = 0; i < foundWorker.Count - 1; i++)
                    {
                        Worker work = company.Departments[foundWorker[0]].Workers[foundWorker[i + 1]];
                        work.SurName = $"{Enter.EnterStringData(Convert.ToByte(choiseMode + 1))}";
                        company.Departments[foundWorker[0]].Workers[foundWorker[i + 1]] = work;
                    }
                    break;                
                case EnterDataEnum.WorkerPosition:
                    for (int i = 0; i < foundWorker.Count - 1; i++)
                    {
                        Worker work = company.Departments[foundWorker[0]].Workers[foundWorker[i + 1]];
                        work.Position = $"{Enter.EnterStringData(Convert.ToByte(choiseMode + 1))}";
                        company.Departments[foundWorker[0]].Workers[foundWorker[i + 1]] = work;
                    }
                    break;
                case EnterDataEnum.WorkerSalary:
                    for (int i = 0; i < foundWorker.Count - 1; i++)
                    {
                        Worker work = company.Departments[foundWorker[0]].Workers[foundWorker[i + 1]];
                        work.Salary = Enter.EnterIntData(Convert.ToByte(choiseMode + 1));
                        company.Departments[foundWorker[0]].Workers[foundWorker[i + 1]] = work;
                    }
                    break;
                default:
                    Console.WriteLine("Wrong data...");
                    break;
            }                       
            return company;
        }
    }
}
