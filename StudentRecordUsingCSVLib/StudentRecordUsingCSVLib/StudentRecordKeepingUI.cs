using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace StudentRecordUsingCSVLib
{
    public partial class StudentRecordKeepingUI : Form
    {

        private string fileLocation = @"studentrecord.csv";

        public StudentRecordKeepingUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream aStreamForReading = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStreamForReading);
            List<string> aRecord = new List<string>();

            while (aReader.ReadRow(aRecord))
            {
                string regNo = aRecord[0];
                if (regNoTextBox.Text == regNo)
                {
                    MessageBox.Show(@"Reg no already exists");
                    aStreamForReading.Close();
                    return;
                }
            }
            aStreamForReading.Close();
            
            FileStream aStream = new FileStream(fileLocation, FileMode.Append);
            CsvFileWriter aWriter = new CsvFileWriter(aStream);
            List<string> aStudentRecord = new List<string>();
            aStudentRecord.Add(regNoTextBox.Text);
            aStudentRecord.Add(nameTextBox.Text);
            aWriter.WriteRow(aStudentRecord);
            aStream.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aStudentRecord = new List<string>();

            studentListBox.Items.Clear();

            while (aReader.ReadRow(aStudentRecord))
            {
                string regNo = aStudentRecord[0];
                string name = aStudentRecord[1];
                studentListBox.Items.Add(regNo + " " + name);
            }
            aStream.Close();
        }
    }
}
