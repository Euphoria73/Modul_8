using System;
using System.Collections.Generic;
using System.Text;

namespace Reestr
{
    static class Start
    {
        public static void StartProgramm()
        {            
            var loadedCompany = Load.LoadingData();
            Menu.StartMenu(loadedCompany);
        }
    }
}
