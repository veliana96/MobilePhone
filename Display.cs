using System;
using System.Text;

namespace DefineClass
{
    class Display
    {
        private double? size = null;
        private int? numberOfColors = null;

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("size can not be less than 0!");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("colors can not be less than 0!");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }

        public Display(double? size, int? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors; 
        }
       
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Display Size: ").Append(this.Size).Append("\r\n");
            builder.Append("Display Colors: ").Append(this.NumberOfColors).Append("\r\n");
            return builder.ToString();
        }
    }
}