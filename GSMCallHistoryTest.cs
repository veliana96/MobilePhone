using System;

namespace DefineClass
{
    class GSMCallHistoryTest
    {
        public static void Main()
        {
            GSM phone1 = new GSM("Iphone6s", "Apple");

            Call first = new Call(phone1, DateTime.Now, "0876050549", 123);
            phone1.AddCall(first);

            Call second = new Call(phone1, DateTime.Now, "0876050548", 200);
            phone1.AddCall(second);

            Call third = new Call(phone1, DateTime.Now, "0876980549", 250);
            phone1.AddCall(third);

            phone1.PrintCallHistory();
            Console.WriteLine("___________________________");
            phone1.CallPrice(0.37);
            Console.WriteLine("___________________________");

            phone1.DeleteCall(2);
            phone1.PrintCallHistory();
            Console.WriteLine("___________________________");
            phone1.CallPrice(0.37);
            Console.WriteLine("___________________________");

            phone1.ClearCallHistory();
            phone1.PrintCallHistory();

        }
    }
}

