using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BspCallJavascript
{
    public class StringUtils
    {
        public static String Concat(String string1, String string2, String string3)
        {
            return string1 + string2 + string3;
        }

        //Not working
        public static String Concat2(params String[] strings)
        {
            return strings.Aggregate((a,b)=>a+b);
        }

    }
}
