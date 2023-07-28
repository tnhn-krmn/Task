using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class TuzelKisiFormatter
    {
        public static string Format(this TuzelKisi tuzelKisi)
        {
            var result = $"Vkn : {tuzelKisi.vkn} - Unvanı : {tuzelKisi.unvani} - Adres : {tuzelKisi.adres} - ";

            foreach (var item in tuzelKisi.gercekKisi)
            {
                result += $"Adı : {item.ad} - Soyad : {item.soyad} - Tckn : {item.tckn}  - Adres : {item.adres}";
            }
            return result;
        }
    }
}
