using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_БД_ООП
{
    class Coding
    {
        //private double Interval_1 
        //{ 
        //    get { return Interval; }
        //    set { Interval = value; }
        //}
        //private double Max_1
        //{
        //    get { return Max; }
        //    set { Max = value; }
        //}
        //private double Min_1
        //{
        //    get { return Min; }
        //    set { Min = value; }
        //}
        private double coef { get; set; }
        public System.Collections.Generic.IEnumerable<double> Code(MainForm.Method mt, double[] list, bool is_coef, double coef)
        {
            List<double> l = new List<double>();
            double Max = list.Max();
            double Min = list.Min();
            double Interval = Math.Abs((Max - Min) / list.Length);
            double am1;
            switch (mt)
            {
                case MainForm.Method.Compress:
                    {
                        l.Clear();
                        if (!is_coef)
                            //коэффициент сжатия
                            coef = (double)(Math.Abs((Max - Min) - 2 * Interval) / (double)Math.Abs(Max - Min));
                        am1 = Min + Interval;

                        l.Add(am1);
                        double diapazon;
                        for (int i = 0; i < list.Length - 1; i++)
                        {
                            diapazon = Math.Abs(list[i] - list[i + 1]);
                            if (diapazon < Interval)
                                l.Add(l[i] + diapazon);
                            else
                                l.Add(l[i] + diapazon * coef);
                        }
                        foreach (double n in l)
                            yield return n;
                        break;
                    }
                case MainForm.Method.Move_Down:
                    {
                        l.Clear();
                        if (!is_coef)
                            //коэффициент сжатия
                            coef = (double)(Math.Abs((Max - Min) - 2 * Interval) / (double)Math.Abs(Max - Min));
                        //коэффициент расширения
                        double kr = 1 / coef;
                        am1 = Min - Interval;

                        l.Add(am1);
                        double diapazon;
                        for (int i = 0; i < list.Length - 1; i++)
                        {
                            diapazon = Math.Abs(list[i] - list[i + 1]);
                            if (diapazon < Interval)
                                l.Add(l[i] + diapazon * kr);
                            else
                                l.Add(l[i] + diapazon * coef);
                        }
                        foreach (double n in l)
                            yield return n;
                        break;
                    }
                case MainForm.Method.Move_Up:
                    {
                        l.Clear();
                        if (!is_coef)
                            //коэффициент сжатия
                            coef = (double)(Math.Abs((Max - Min) - 2 * Interval) / (double)Math.Abs(Max - Min));
                        //коэффициент расширения
                        double kr = 1 / coef;
                        am1 = Min + Interval;

                        l.Add(am1);
                        double diapazon;
                        for (int i = 0; i < list.Length - 1; i++)
                        {
                            diapazon = Math.Abs(list[i] - list[i + 1]);
                            if (diapazon < Interval)
                                l.Add(l[i] + diapazon * kr);
                            else
                                l.Add(l[i] + diapazon * coef);
                        }
                        foreach (double n in l)
                            yield return n;
                        break;
                    }
                case MainForm.Method.Widening:
                    {
                        l.Clear();
                        if (!is_coef)
                            //коэффициент сжатия
                            coef = (double)(Math.Abs((Max - Min) - 2 * Interval) / (double)Math.Abs(Max - Min));
                        //коэффициент расширения 2
                        double k1 = (1 + coef) / 2;
                        am1 = Min - Interval;

                        l.Add(am1);
                        double diapazon1;
                        for (int i = 0; i < list.Length - 1; i++)
                        {
                            diapazon1 = Math.Abs(list[i] - list[i + 1]);
                            if (diapazon1 < Interval)
                                l.Add(l[i] + diapazon1 * coef);
                            else
                                l.Add(l[i] + diapazon1 * k1);
                        }
                        foreach (double n in l)
                            yield return n;
                        break;
                    }
                    
            }
        }
    }
}
