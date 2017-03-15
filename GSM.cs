using System;
using System.Collections.Generic;
using System.Text;

namespace DefineClass
{
    class GSM
    {
        private string model = null;
        private string manufacturer = null;
        private double? price = null;
        private string owner = null;
        private Battery batteryTip = null;
        private Display displayTip = null;
        public static readonly GSM Iphone4s = new GSM("Iphone 4S", "Apple", 1500.00, "Veliana", new Battery("AH67", 200.0, 14.0, BatteryTipe.LiIon), new Display(47.6, 500));
        private List<Call> callHistory = new List<Call>(); 

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Enter valid model name!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Enter valid manufacturer!");
                }

                this.manufacturer = value;
            }
        }

        public double? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                this.owner = value;
            }
        }

        public Battery BatteryTip
        {
            get
            {
                return this.batteryTip;
            }

            set
            {
                this.batteryTip = value;
            }
        }

        public Display DisplayTip
        {
            get
            {
                return this.displayTip;
            }

            set
            {
                this.displayTip = value;
            }
        }

        public List<Call> CallHistory { get; private set; }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, double? price, string owner, Battery batteryTip, Display displayTip) : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.DisplayTip = displayTip;
            this.BatteryTip = batteryTip;
        }       

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("Model: ").Append(this.Model).Append("\r\n");
            builder.Append("Manufacturer: ").Append(this.Manufacturer).Append("\r\n");
            builder.Append("Price: ").Append(this.Price).Append("\r\n");
            builder.Append("Owner: ").Append(this.Owner).Append("\r\n");

            if (this.BatteryTip != null)
            {
                builder.Append(this.BatteryTip.ToString());
            }
            else
            {
                builder.Append("Battery Hours Idle: ").Append("\r\n");
                builder.Append("Battery Hours Talk: ").Append("\r\n");
                builder.Append("Battery Model: ").Append("\r\n");
                builder.Append("Battery Type: ").Append("\r\n");
            }

            if (this.DisplayTip != null)
            {
                builder.Append(this.DisplayTip.ToString());
            }
            else
            {
                builder.Append("Display Size: ").Append("\r\n");
                builder.Append("Display Colors: ").Append("\r\n");
            }

            return builder.ToString();
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(int index)
        {
            this.callHistory.Remove(this.callHistory[index]);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public void PrintCallHistory()
        {
            foreach (var item in this.callHistory)
            {
                Console.WriteLine(item);
            }
        }

        public void CallPrice(double perMinute)
        {
            double? sum = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                sum += (this.callHistory[i].Time / 60) * perMinute;
            }

            Console.WriteLine("The Total price is {0:F2} lv", sum);
        }

    }
}
