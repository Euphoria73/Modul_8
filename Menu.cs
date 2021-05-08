using System;


namespace Reestr
{
    static class Menu
    {
        public static Department StartMenu(Department company)
        {           
            Modes mode = new Modes();
            byte selectMode = SelectMode.Select();            
            var companyAfterWork = mode.Mode(selectMode, company);
            Console.WriteLine("Repeat programm? 1 - Yes, 2 - No");
            var newStart = Console.ReadLine();
            if (newStart != "1")
            {

                return companyAfterWork;
            }
            else
            {               
                return Menu.StartMenu(companyAfterWork);
            }
        }
    }
}
