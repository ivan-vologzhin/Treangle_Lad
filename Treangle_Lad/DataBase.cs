using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treangle_Lad;

namespace Treangle_Lad
{
    internal class DataBase
    {
        public static TreangleEntities dB = new TreangleEntities();
        public static TreanglIF SearchInfo(string f, string s, string t)
        {
            return dB.TreanglIF.FirstOrDefault(u => u.firsts == f && u.seconds == s && u.thirds == t);
        }

        public static TreanglIF AddInfo(string f, string s, string t)
        {
            var triangle = Treangless.GoTriangle(f, s, t);
            TreanglIF tr = new TreanglIF();
            tr.firsts = f;
            tr.seconds = s;
            tr.thirds = t;
            tr.typess = triangle.Item1;
            tr.exception = triangle.Item5;
            dB.TreanglIF.Add(tr);
            dB.SaveChanges();

            return tr;
        }

        public static void DeleteInfo(string f, string s, string t)
        {
            TreanglIF triangle = dB.TreanglIF.FirstOrDefault(u => u.firsts == f && u.seconds == s && u.thirds == t);
            dB.TreanglIF.Remove(triangle);
            dB.SaveChanges();
        }
    }
}
