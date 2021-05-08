using System;
using System.Collections.Generic;
using System.Text;

namespace Reestr
{
    class Modes
    {        
        public Department Mode(byte byteEnterMode, Department company)
        {                        
            Sort sort = new Sort();            
            Import import = new Import();
            Create create = new Create();           
            Change change = new Change();
            Delete delete = new Delete();
            Save save = new Save();

            string pathToOwnerFile = AppDomain.CurrentDomain.BaseDirectory; //path to the file
            
            switch ((ModeEnum)byteEnterMode)
            {
                case ModeEnum.Cancel:
                    Console.WriteLine("Quest complited. Good luck!");
                    return company;                    
                case ModeEnum.CreateDepartment:
                    Console.WriteLine("Create new department:");
                    var addedDepartmentToCompany = create.CreateNewDepartment(byteEnterMode, company);                   
                    PrintCompany.PrintDepartment(addedDepartmentToCompany);
                    return addedDepartmentToCompany;                    
                case ModeEnum.CreateWorker:
                    Console.WriteLine("Enter the firstname of the employee, please: ");
                    var addedWorkerToDepartment = create.CreateNewWorker(company);
                    PrintCompany.PrintDepartment(addedWorkerToDepartment);
                    return addedWorkerToDepartment;
                case ModeEnum.ChangeDepartment:
                    Console.WriteLine("Enter the surname of the employee, please: ");                    
                    var changedDepartment = change.ChangeDepartment(company);
                    PrintCompany.PrintDepartment(changedDepartment);
                    return changedDepartment;
                case ModeEnum.ChangeWorker:
                    Console.WriteLine("Enter the age of the employee, please: ");
                    PrintCompany.PrintDepartment(company);
                    var changedWorker = change.ChangeWorker(company);
                    PrintCompany.PrintDepartment(changedWorker);
                    return changedWorker;
                case ModeEnum.DeleteDepartment:
                    Console.WriteLine("Enter the position of the employee, please: ");
                    var deletedDepartment = delete.DeleteDepartment(company);
                    PrintCompany.PrintDepartment(deletedDepartment);
                    return deletedDepartment; 

                case ModeEnum.DeleteWorker:
                    Console.WriteLine("Enter the salary of the employee, please: ");
                    var deletedWorker = delete.DeleteWorker(company);
                    PrintCompany.PrintDepartment(deletedWorker);
                    return deletedWorker;
                case ModeEnum.SortOnlyAge:
                    sort.SortOnlyAge(company);
                    break;
                case ModeEnum.SortAgeAndSalary:
                    sort.SortAgeAndSalary(company);
                    break;
                case ModeEnum.SortAgeAndSalaryInEachDepartment:                    
                    sort.SortAgeAndSalaryInEachDepartment(company);                    
                    break;                    
                case ModeEnum.ImportXML:
                    company = import.ImportXml(pathToOwnerFile);
                    PrintCompany.PrintDepartment(company);
                    break;
                case ModeEnum.ImportJSON:
                    company = import.ImportJson(pathToOwnerFile);
                    PrintCompany.PrintDepartment(company);
                    break;
                case ModeEnum.ExportXML:                   
                    save.SaveXml(pathToOwnerFile, company);                    
                    break;
                case ModeEnum.ExportJSON:                    
                    save.SaveJson(pathToOwnerFile, company);
                    break;
                case ModeEnum.PrintInformation:
                    PrintCompany.PrintDepartment(company);
                    break;
                default:
                    break;
            }            
            return company;
        }
    }
}
