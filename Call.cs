using System;
using System.Text;

namespace DefineClass
{
    class Call
    {
        private GSM phone;
        private DateTime date;
        private string number;
        private double? time;

        public DateTime Date { get; set; }
        public GSM Phone { get; set; }
        public string Number { get; set; }
        public double? Time { get; set; }

        public Call(GSM phone, DateTime date, string number, double? time)
        {
            this.Date = date;
            this.Phone = phone;
            this.Number = number;
            this.Time = time;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Model: ").Append(this.Phone.Model).Append("\r\n");
            builder.Append("Manufacturer: ").Append(this.Phone.Manufacturer).Append("\r\n");
            builder.Append("Date: ").Append(this.Date).Append("\r\n");
            builder.Append("Dialled Phone Number: ").Append(this.Number).Append("\r\n");
            builder.Append("Duration: ").Append(this.Time).Append("\r\n");

            return builder.ToString();
        }
    }
}
