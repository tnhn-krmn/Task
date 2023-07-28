using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public record Para
    {
        public decimal Value { get; init; }
        public string Birim { get; init; }

        public Para(decimal value, string birim)
        {
            Value = value;
            Birim = birim;
        }

        public static Para operator +(Para left, Para right)
        {
            if (left.Birim != right.Birim)
            {
                new ArgumentException("Para birimleri aynı değil.");
            }
            else if (left.Birim != "tr" && right.Birim == "tr")
            {
                return new Para((left.Value * 30) + right.Value, right.Birim);
            }
            else if (left.Birim == "tr" && right.Birim != "tr")
            {
                return new Para((right.Value * 30) + left.Value, right.Birim);
            }

            return null;
        }



        public static Para operator -(Para left, Para right)
        {
            if (left.Birim != right.Birim)
            {
                new ArgumentException("Para birimleri aynı değil.");
            }
            else if (left.Birim != "tr" && right.Birim == "tr")
            {
                return new Para((left.Value * 30) - right.Value, right.Birim);
            }
            else if(left.Birim == "tr" && right.Birim != "tr")
            {
                return new Para((right.Value * 30) - left.Value, right.Birim);
            }

            return null;
        }

    }
}
