using System;

namespace DefineClass
{
    class GSMTest
    {      
      
        public static void PrintPhones()
        {
            GSM[] mobilePhones = AddPhones();
            foreach (var phone in mobilePhones)
            {
                Console.WriteLine(phone);
            }
        }

        public static GSM[] AddPhones()
        {
            GSM[] mobilePhones =
            {
                new GSM("GALAXY S7 Edge", "SAMSUNG", 1500, "Sasho", new Battery("HT87", 190.0, 12.0, BatteryTipe.NiCD), new Display(45.0, 300)),
                new GSM("G5", "LG", 800, "Vlado", new Battery("JGA1", 120, 5, BatteryTipe.NiCD), new Display(5.2, 900)),
                new GSM("M2", "Sony", 200, "Mirela", new Battery("JK8", 170, 12, BatteryTipe.NiMH), new Display(5, 700)),
                new GSM("P9", "Huawei")
            };

            return mobilePhones;
        }

        public static void DisplayInfoIphone4S()
        {
            Console.WriteLine(GSM.Iphone4s);
        }
        
    }
    
 }
