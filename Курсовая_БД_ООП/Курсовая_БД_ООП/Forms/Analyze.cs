using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_БД_ООП
{
    public partial class Analyze : Form
    {
        bool[] answer;
        public Analyze(bool[] answer, int a, int b)
        {
            InitializeComponent();
            this.answer = answer;
            label1.Text = "Могут ли в поле С присутствовать значения равные либо меньше, чем " + a + "?";
            label2.Text = "Могут ли в поле С присутствовать значения равные либо больше, чем " + b + "?";
            radioButton1.Text = "Да";
            radioButton2.Text = "Нет";
            radioButton3.Text = "Да";
            radioButton4.Text = "Нет";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                answer[0] = true;
            else if (radioButton2.Checked == true)
                answer[0] = false;
            if (radioButton3.Checked == true)
                answer[1] = true;
            else if (radioButton4.Checked == true)
                answer[1] = true;
            this.Close();
        }
    }
}
