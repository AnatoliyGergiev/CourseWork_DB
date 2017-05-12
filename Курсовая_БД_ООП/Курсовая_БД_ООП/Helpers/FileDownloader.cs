using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Курсовая_БД_ООП
{
    class FileDownloader: IDownloader
    {
        public double[] Download()
        {
            ArrayList al = new ArrayList();
            string filename = "../../file.txt";
            StreamReader sr = new StreamReader(filename, Encoding.UTF8);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                al.Add(Convert.ToDouble(line));
            }
            sr.Close();
            double[] d = new double[al.Count];
            for (int i = 0; i < al.Count; i++)
                 d[i] = (double)al[i];
            return d;
        }
    }
}
