using System;
using System.Text;

namespace DefineClass
{
    class Battery
    {
        private string model = null;
        private double? hoursIdle = null;
        private double? hoursTalk = null;
        private BatteryTipe tipe;

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("hours can not be less than 0!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("hours can not be less than 0!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryTipe Tipe
        {
            get
            {
                return this.tipe;
            }

            set
            {
                this.tipe = value;
            }
        }

        public Battery(string model, double? hoursIdle, double? hoursTalk, BatteryTipe batteryTipe)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Tipe = tipe;
        }
       
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Battery Hours Idle: ").Append(this.HoursIdle).Append("\r\n");
            builder.Append("Battery Hours Talk: ").Append(this.HoursTalk).Append("\r\n");
            builder.Append("Battery Model: ").Append(this.Model).Append("\r\n");
            builder.Append("Battery Type: ").Append(this.Tipe).Append("\r\n");

            return builder.ToString();
        }
    }
}
