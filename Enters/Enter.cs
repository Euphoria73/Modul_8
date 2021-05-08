using System;
using System.Collections.Generic;
using System.Text;

namespace Reestr
{
    class Enter
    {
        public static byte ChoiseMode()
        {
            string stringEnter = "";
            byte byteEnterMode;
            while (!Byte.TryParse(stringEnter, out byteEnterMode))
            {
                Console.WriteLine("Enter the number of mode, please: ");
                try
                {
                    byteEnterMode = Convert.ToByte(Console.ReadLine());
                    return byteEnterMode;
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a number.");
                }         
            }
            return byteEnterMode;
        }
        public static string EnterStringData(byte byteEnterData)
        {
            string enterData = "No information";
            switch ((EnterDataEnum)byteEnterData)
            {
                case EnterDataEnum.NameOfDepartment:
                    Console.WriteLine("Enter the Name of the department, please: ");
                    enterData = Console.ReadLine();
                    return enterData;                                   
                case EnterDataEnum.WorkerFirstName:
                    Console.WriteLine("Enter the Firstname of the employee, please: ");
                    enterData = Console.ReadLine();
                    return enterData;                    
                case EnterDataEnum.WorkerSurName:
                    Console.WriteLine("Enter the Surname of the employee, please: ");
                    enterData = Console.ReadLine();
                    return enterData;                
                case EnterDataEnum.WorkerPosition:
                    Console.WriteLine("Enter the Position of the employee, please: ");
                    enterData = Console.ReadLine();
                    return enterData;                
                default:
                    return enterData;                                  
            }           
        }
        public static int EnterIntData(byte byteEnterData)
        {
            string enterStringData = "";
            int enterIntegerData = 0;
            switch ((EnterDataEnum)byteEnterData)
            {
                case EnterDataEnum.WorkerID:
                    while (!int.TryParse(enterStringData, out enterIntegerData))
                    {
                        Console.WriteLine("Enter the ID of the employee, please: ");
                        try
                        {
                            enterIntegerData = Convert.ToInt32(Console.ReadLine());
                            return enterIntegerData;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number.");
                        }
                    }
                    return enterIntegerData;
                case EnterDataEnum.WorkerAge:
                    while (!int.TryParse(enterStringData, out enterIntegerData))
                    {
                        Console.WriteLine("Enter the Age of the employee, please: ");
                        try
                        {
                            do
                            {
                                enterIntegerData = Convert.ToInt32(Console.ReadLine());    
                            } while (enterIntegerData < 0 || enterIntegerData > 100);
                            
                            return enterIntegerData;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number.");
                        }
                    }
                    return enterIntegerData;
                case EnterDataEnum.WorkerSalary:
                    while (!int.TryParse(enterStringData, out enterIntegerData))
                    {
                        Console.WriteLine("Enter the Salary of the employee, please: ");
                        try
                        {
                            enterIntegerData = Convert.ToInt32(Console.ReadLine());
                            return enterIntegerData;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number.");
                        }
                    }
                    return enterIntegerData;
            }
            return enterIntegerData;
        }
        
    }
}
