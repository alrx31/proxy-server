using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    class Program
    {
        public static string blackListFileName = "./../../../black_list.txt";
        public static string[] blackList;

        static void Main(string[] args)
        {
            string buf = BlackList.GetBlackList(blackListFileName);
            blackList = buf.Trim().Split('\r', '\n');
            Proxy.Start();
        }
    }
}
