using System;
using System.Collections.Generic;
using System.Text;

namespace Reestr
{
    static class SelectMode
    {
        static public byte Select()
        {
            Console.WriteLine("Select an action:");
            Console.WriteLine(
                "Create department = 1,\n" +
                "Add new an empoyee = 2,\n" +
                "Change depertment details = 3,\n" +
                "Change employee details= 4,\n" +
                "Delete department = 5,\n" +
                "Delete employee = 6,\n" +
                "sorting employees only by age in all departments = 7,\n" +
                "sorting employees by age and salary in all departments = 8,\n" +
                "sorting employees by age and salary in each department = 9,\n" +
                "Import file in XML format = 10,\n" +
                "Import file in JSON format = 11,\n" +
                "Save file in XML format = 12,\n" +
                "Save file in JSON format = 13\n" +
                "Cancel = 0");
            byte choiseMode = Enter.ChoiseMode();
            return choiseMode;
        }
    }
}
