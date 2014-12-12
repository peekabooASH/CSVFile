using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace file_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string location = @"D:\c.txt ";
        int id, salary, amount;
        string name;
        private void saveButton_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(idTesxtbox.Text);
            name = nameTextBox.Text;
            salary = Convert.ToInt32(salarytextBox.Text);
            FileStream aFileStream=new FileStream(location,FileMode.Append);
            StreamWriter aStreamWriter=new StreamWriter(aFileStream);
            aStreamWriter.Write(name + "," + id + "," + salary + ",");
           // aStreamWriter.Write();
            //aStreamWriter.Write();
            aStreamWriter.WriteLine();
          
            aStreamWriter.Close();
            idTesxtbox.Text="";
            nameTextBox.Text = "";
            salarytextBox.Text = "";

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(location, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            amountTextbox.Text = "";
            double totalSalary = 0;
            while (!aStreamReader.EndOfStream)
            {
              string line = aStreamReader.ReadLine();
              listBox1.Items.Add(line);
              string[] employeeInfo = line.Split(',');

              listBox1.Items.Add(employeeInfo[0] + " " + employeeInfo[1] + " " + employeeInfo[2]);
              double employeesalary = Convert.ToDouble(employeeInfo[2]);
              totalSalary += employeesalary;

            }
           
            amountTextbox.Text = totalSalary.ToString();

            aStreamReader.Close();
        }
    }
}
