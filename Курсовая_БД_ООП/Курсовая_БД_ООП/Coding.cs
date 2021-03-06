﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_БД_ООП
{
    class Coding
    {
        public double min { get; set; }
        public double max { get; set; }
        private double coef { get; set; }
        private void ret_sort(double[] list, double[] list_1, List<double> l)
        {
            double[] l1 = new double[l.Count];
            l.CopyTo(l1);
            int[] ind = new int[list_1.Length];
            for (int i = 0; i < list.Length; i++)
            {
                ind[i] = Array.IndexOf(list_1, list[i]);
            }
            for (int i = 0; i < list_1.Length; i++)
                l[ind[i]] = l1[i]; 
        }
        public System.Collections.Generic.IEnumerable<double> Code(MainForm.Method mt, double[] list_1, bool is_coef, double coef)
        {
            double[] list = new double[list_1.Length];
            list_1.CopyTo(list, 0);
            Array.Sort(list);
            List<double> l = new List<double>();
            double Max = list.Max();
            double Min = list.Min();
            min = Min;
            max = Max;
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
                        ret_sort(list, list_1, l);
                        foreach (double n in l)
                            yield return Math.Round(n);
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
                        ret_sort(list, list_1, l);
                        foreach (double n in l)
                            yield return Math.Round(n);
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
                        ret_sort(list, list_1, l);
                        foreach (double n in l)
                            yield return Math.Round(n);
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
                        ret_sort(list, list_1, l);
                        foreach (double n in l)
                            yield return Math.Round(n);
                        break;
                    }
            }
        }
    }
}
