using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_БД_ООП
{
    class Model
    {
        double[] L_Start;
        double[] L_Encoded;
        public double[] List_Start
        {
            get 
            {
                return L_Start;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                    L_Start[i] = value[i];
            }
        }
        public double[] List_Encoded
        {
            get
            {
                return L_Encoded;
            }
            set
            {
                L_Encoded = value;
            }
        }
        private readonly IDownloader downloader;
        public Model(IDownloader downloader)
        {
            this.downloader = downloader;
        }
        public void Download()
        {
            L_Start = downloader.Download();
        }
    }
}
