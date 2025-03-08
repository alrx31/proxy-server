using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    public class BlackList
    {
        public static string GetBlackList(string fileName)
        {
            string bufList = "";
            try
            {
                StreamReader fileStream = new StreamReader(fileName, System.Text.Encoding.Default);
                bufList = fileStream.ReadToEnd();
            }
            catch
            {
                return bufList;
            }
            
            return bufList;
        }
    }
}
