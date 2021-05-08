using System;
using System.Collections.Generic;


namespace Reestr
{
    class Found
    {
        public int FoundDepartament(Department company)
        {
            Console.WriteLine("Select department by number:");
            //display all departments with an index of the number of each department for selection by the user
            int numberOfDepartment = 0; 
            foreach (var department in company.Departments)
            {
                Console.WriteLine($"{numberOfDepartment + 1}     " + department.Print());
                numberOfDepartment++;
            }
            // Selection the certain department by the user
            int  choseDepartament = company.Departments.Count + 1;  
            while (choseDepartament < 0 || choseDepartament > company.Departments.Count)
            {                
                try
                {
                    choseDepartament = Convert.ToByte(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong data");
                }
            }                
            return choseDepartament - 1;
        }
        public List<int> FoundWorker(Department company)
        {
            Console.WriteLine("Select department by number for find the emploee:");
            int numberDepartment = FoundDepartament(company);
            Console.WriteLine("Enter the Surname of the employee to search for:");      
           string foundSurname = Console.ReadLine();

            //add the department index as a zero sheet element for subsequent work with it
            List<int> listValuesForFindWorker = new List<int>
            {
                numberDepartment
            };
            foreach (var worker in company.Departments[numberDepartment].Workers)
                {
                    bool containsSearchResult = worker.SurName.Contains(foundSurname, System.StringComparison.CurrentCultureIgnoreCase);                    
                    if (containsSearchResult) 
                    {                        
                        int numberWorker = company.Departments[numberDepartment].Workers.IndexOf(worker);
                        listValuesForFindWorker.Add(numberWorker);
                        Console.WriteLine(worker.Print());
                    }                    
                }
            if (listValuesForFindWorker.Count > 2) //When found some employees then user select only one of them
            {
                Console.WriteLine("Select employee by ID:");
                int selectWorker = 0;
                while (selectWorker <= 0 || selectWorker > company.Departments[numberDepartment].Workers.Count+1)
                {
                    try
                    {
                        selectWorker = Convert.ToByte(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wrong data");
                        Console.WriteLine("Select correct employee by ID, please:");
                    }
                }
                listValuesForFindWorker.Clear();
                listValuesForFindWorker.Add(numberDepartment);
                listValuesForFindWorker.Add(selectWorker-1);
            }
            if (listValuesForFindWorker.Count == 1) 
            {
                Console.WriteLine("Employee not found\n");               
                Menu.StartMenu(company);
            }
            
            return listValuesForFindWorker;
        }
    }
}
