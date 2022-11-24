using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Creating_Text_File___DAYLAG
{
    public partial class FrmRegistration : Form
    {
        public static string fileName;
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileName = textBox1.Text + ".txt";

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
            {
                outputFile.WriteLine("Student No.: " + textBox1.Text);
                outputFile.WriteLine("Full Name: " + textBox2.Text + ", " + textBox4.Text + " " + textBox6.Text + ".");
                outputFile.WriteLine("Program: " + comboBox1.Text);
                outputFile.WriteLine("Gender: " + comboBox2.Text);
                outputFile.WriteLine("Age: " + textBox3.Text);
                outputFile.WriteLine("Birthday: " + dateTimePicker1.Text);
                outputFile.WriteLine("Contact No.: " + textBox5.Text);
                Console.WriteLine(fileName);

                Close();
            }

            
        }
    }
}
