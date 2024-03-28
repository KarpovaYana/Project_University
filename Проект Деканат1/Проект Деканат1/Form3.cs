using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Проект_Деканат1.exception;
using static Проект_Деканат1.Form1;

namespace Проект_Деканат1
{
    static public class StudentF
    {
        static public Student student = new Student("", "", true);
    }
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            radioButton1.Checked = true;    
        }

        bool checkName(string name)
        {
            try { exception.Exception(name, ExceptionType.ExceptionName); }
            catch
            {
                MessageBox.Show("Некорректное ФИО");
                return false;
            }
            return true;
        }

        bool checkBirth(string Birth)
        {
            try { exception.Exception(Birth, ExceptionType.ExceptionBirth); }
            catch { MessageBox.Show("Некорректная дата"); return false; }
            return true;
        }


        bool checkCorrectness()
        {
            if (!checkName(textBox1.Text)) return false;
            if (!checkBirth(textBox2.Text)) return false;

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkCorrectness()) return;

            StudentF.student.Name = textBox1.Text;
            StudentF.student.Birth = textBox2.Text;
            StudentF.student.Salary = radioButton1.Checked;

            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
