using System;
using System.Collections.Generic;
using System.Text;

namespace Reestr
{
    enum ModeEnum:byte
    {
        Cancel = 0,
        CreateDepartment = 1, 
        CreateWorker = 2,
        ChangeDepartment = 3, 
        ChangeWorker = 4, 
        DeleteDepartment = 5, 
        DeleteWorker = 6, 
        SortOnlyAge = 7, 
        SortAgeAndSalary = 8, 
        SortAgeAndSalaryInEachDepartment = 9, 
        ImportXML = 10,
        ImportJSON = 11,
        ExportXML = 12,
        ExportJSON = 13,            
        PrintInformation =14
    }
}
