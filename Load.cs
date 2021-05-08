using System;
using System.Collections.Generic;
using System.Text;

namespace Reestr
{
    static class Load
    {
        static public Department LoadingData()
        {
            Import import = new Import();
            string pathToOwnerFile = AppDomain.CurrentDomain.BaseDirectory; //path to the file
            Department company = import.DefaultImportJson(pathToOwnerFile); //import from the file            
            return company;
        }
    }
}
