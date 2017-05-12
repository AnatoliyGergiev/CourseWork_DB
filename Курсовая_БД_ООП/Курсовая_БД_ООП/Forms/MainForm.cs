using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая_БД_ООП.Forms;

namespace Курсовая_БД_ООП
{
    public partial class MainForm : Form, IMainForm
    {
        public event EventHandler<EventArgs> Download_file;
        public event EventHandler<EventArgs> Update;
        private Coding coding;
        public bool[] answer = new bool[2];
        public enum Method
        {
            Compress,
            Move_Down,
            Move_Up,
            Widening
        }
        public double Coef 
        { 
            get 
            {
                return Convert.ToDouble(textBox1.Text);
            } 
            set
            {
                textBox1.Text = value.ToString();
            } 
        }
        double[] L_Start;
        double[] L_Encoded;
        public double[] List_Encoded 
        { 
            set 
            {
                listBox2.Items.Clear();
                for (int i = 0; i < value.Length; i++)
                {
                    listBox2.Items.Add(value[i]);
                }
            }
            get
            {
                return L_Encoded;
            }
        }
        public double[] List_Start 
        {
            set 
            {
                listBox1.Items.Clear();
                for (int i = 0; i < value.Length; i++)
                {
                    listBox1.Items.Add(value[i]);
                }
                L_Start = value;
            } 
        }
        public MainForm()
        {
            InitializeComponent();
            MainPresenter pr = new MainPresenter(this);
            coding = new Coding();
        }

        //Кодировать
        private void button3_Click(object sender, EventArgs e)
        {
            //using(SqlC\onnection sc=new SqlConnection("team.sql"));  
            bool is_coef = false;
            double dn = 0;
            L_Encoded = new double[L_Start.Length];
            if (textBox1.Text != "")
            {
                is_coef = true;
                string str = textBox1.Text;
                str = str.Replace('.',',');
                dn = Convert.ToDouble(str);
            }
            if (radioButton_Compress.Checked == true)
            {
                int i = 0;
                foreach (double d in coding.Code(Method.Compress, L_Start, is_coef, dn))
                {
                    L_Encoded[i] = d;
                    i++;
                }
            }
            if (radioButton_MoveUp.Checked == true)
            {
                int i = 0;
                foreach (double d in coding.Code(Method.Move_Up, L_Start, is_coef, dn))
                {
                    L_Encoded[i] = d;
                    i++;
                }
            }
            if (radioButton_MoveDown.Checked == true)
            {
                int i = 0;
                foreach (double d in coding.Code(Method.Move_Down, L_Start, is_coef, dn))
                {
                    L_Encoded[i] = d;
                    i++;
                }
            }
            if (radioButton_Widening.Checked == true)
            {
                int i = 0;
                foreach (double d in coding.Code(Method.Widening, L_Start, is_coef, dn))
                {
                    L_Encoded[i] = d;
                    i++;
                }
            }
            List_Encoded = L_Encoded;
            if (Update != null)
                Update(this, EventArgs.Empty);
        }

        //Анализировать
        private void button1_Click(object sender, EventArgs e)
        {
            double Min = L_Start.Min();
            double Max = L_Start.Max();
            double Interval = Math.Abs((Max - Min) / L_Start.Length);
            Analyze a = new Analyze(answer, (int)(Min-Interval), (int)(Max+Interval));
            a.ShowDialog();

            button_SetCoef.Enabled = true;
            button_Code.Enabled = true;

            if (answer[0] && answer[1])
            {
                radioButton_Compress.Enabled = true;
                radioButton_MoveDown.Enabled = true;
                radioButton_MoveUp.Enabled = true;
                radioButton_Widening.Enabled = true;
            }
            if(answer[0] && !answer[1])
            {
                radioButton_Compress.Enabled = true;
                radioButton_MoveDown.Enabled = true;
            }
            if(!answer[0] && answer[1])
            {
                radioButton_Compress.Enabled = true;
                radioButton_MoveUp.Enabled = true;
            }
            if (!answer[0] && !answer[1])
                radioButton_Compress.Enabled = true;
        }

        //Проверка на ввод коэффициента кодирования
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == ',' || e.KeyChar == '.') && !(sender as TextBox).Text.Contains('.'))
                e.KeyChar = '.';
            else if (!(Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void изФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_Analyze.Enabled = true;
            button_Sort.Enabled = true;
            if (Download_file != null)
                Download_file(this, EventArgs.Empty);
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            Array.Sort(L_Start);
            List_Start = L_Start;
            if (listBox2.Items.Count != 0)
            {
                Array.Sort(L_Encoded);
                List_Encoded = L_Encoded;
            }
            if (Update != null)
                Update(this, EventArgs.Empty);
        }

        private void изБазыДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var databaseSelectionForm = new DataBaseSelection();
            databaseSelectionForm.ShowDialog();
        }
    }
}
