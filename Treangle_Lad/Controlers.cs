using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treangle_Lad
{
    public class Controlers
    {
        public static TreanglIF GoControl(string f, string s, string t)
        {
            TreanglIF triangle = new TreanglIF();

            if (DataBase.SearchInfo(f, s, t) == null) DataBase.AddInfo(f, s, t);
            Send send = new Send();
            send.SendInfo(DataBase.SearchInfo(f, s, t));
            return DataBase.SearchInfo(f, s, t);
        }
    }
}
