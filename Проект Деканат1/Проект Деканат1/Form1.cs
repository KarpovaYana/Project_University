using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Проект_Деканат1.StudentF;
using static Проект_Деканат1.Student;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.IO;

namespace Проект_Деканат1
{
    public partial class Form1 : Form
    {
        static List<Student> students = new List<Student>();    
        public Form1()
        {
            InitializeComponent();
            inputData();
        }
        
        Student GetStudent(string line)
        {
            string[] words = line.Split(' ');
            string name = words[0] + " " + words[1];
            bool salary = true;
            if (words[3] == "Нет") salary = false;

            Student a = new Student(name, words[2], salary);
            return a;
        }

        void initializeInfo(string nameFile)
        {
            int size = Convert.ToInt32(File.ReadLines("students.txt").First());
            int index = 0;
            foreach (var line in File.ReadAllLines(nameFile))
            {
                if (index++ == 0) continue;
                if (size--==0) break;
                students.Add(GetStudent(line));
            }
        }

        void inputData()
        {
            initializeInfo("students.txt");
            RenewTable();
        }

        bool isBiggerDate(string a, string b)
        {
            int day1, month1, year1;
            int.TryParse(a.Substring(0, 2), out day1);
            int.TryParse(a.Substring(3, 2), out month1);
            int.TryParse(a.Substring(6), out year1);

            int day2, month2, year2;
            int.TryParse(b.Substring(0, 2), out day2);
            int.TryParse(b.Substring(3, 2), out month2);
            int.TryParse(b.Substring(6), out year2);

            if (year1 < year2) return false;
            if (year1 == year2 && month1 < month2) return false;
            if (year1 == year2 && month1 == month2 && day1 < day2) return false;
            return true;
        }

        void findYoungest()
        {
            Student max = new Student("a", "00.00.0000", true);
            for(int i=0; i<students.Count; i++)
            {
                if (isBiggerDate(students[i].Birth, max.Birth)) max = students[i];
            }

            youngest.Text = max.Name;
        }

        void findOldest()
        {
            Student min = new Student("a", "99.99.9999", true);
            for (int i = 0; i < students.Count; i++)
            {
                if (!isBiggerDate(students[i].Birth, min.Birth)) min = students[i];
            }

            oldest.Text = min.Name;
        }

        void RenewTable()
        {
            if(dataGridView2!=null)dataGridView2.Rows.Clear();

            for (int i = 0; i < students.Count; i++)
            {
                DataGridViewTextBoxCell number = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell name = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell birth = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell salary = new DataGridViewTextBoxCell();

                number.Value = i + 1;
                name.Value = students[i].Name;
                birth.Value = students[i].Birth;
                if(students[i].Salary) salary.Value = "Да";
                else salary.Value = "Нет";

                DataGridViewRow row0 = new DataGridViewRow();
                row0.Cells.AddRange(number, name, birth, salary);
                dataGridView2.Rows.Add(row0);
            }
            findYoungest();
            findOldest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
            Student a = new Student(StudentF.student.Name, StudentF.student.Birth, StudentF.student.Salary);
            students.Add(a);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
            Student a = new Student(StudentF.student.Name, StudentF.student.Birth, StudentF.student.Salary);
            students.Add(a);
            RenewTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            students.Sort((b1,b2)=>b1.Name.CompareTo(b2.Name));
            RenewTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number;
            if(!int.TryParse(textBox1.Text, out number))
            {
                MessageBox.Show("Неправильный номер!");
                return;
            }
            if(number-1>students.Count)
            {
                MessageBox.Show("Неправильный номер!");
                return;
            }
            students.RemoveAt(number - 1);
            RenewTable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            lines.Add(Convert.ToString(students.Count));
            for(int i=0; i<students.Count; i++)
            {
                if (students[i].Salary) lines.Add(students[i].Name +" " + students[i].Birth + " " +"Да");
                else lines.Add(students[i].Name + " " + students[i].Birth + " " + "Нет");
            }

            File.WriteAllLines("students.txt", lines);
        }
    }
}
