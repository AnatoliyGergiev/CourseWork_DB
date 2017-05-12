using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_БД_ООП
{
    interface IMainForm
    {
        double Coef { get; set; }
        double[] List_Encoded { set; get; }
        double[] List_Start { set; }
        //void Code(MainForm.Method mt);
        event EventHandler<EventArgs> Download_file;
        event EventHandler<EventArgs> Update;
    }
}
