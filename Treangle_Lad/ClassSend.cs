using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treangle_Lad
{
    public interface ISend
    {
        void SendInfo(TreanglIF triangle);
    }
    public class Send : ISend
    {
        public void SendInfo(TreanglIF triangle)
        {
            Console.WriteLine($"Отправка данных: {triangle.firsts} {triangle.seconds} {triangle.thirds} {triangle.typess}");
        }
    }
}
