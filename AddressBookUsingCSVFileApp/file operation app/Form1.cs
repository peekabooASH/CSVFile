using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CSVLib;

namespace file_operation_app
{
    public partial class searchButton : Form
    {
        private string fname = @"D:\c.csv";
        public searchButton()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Name",70);
            listView1.Columns.Add("Email", 100);
            listView1.Columns.Add("Contact", 70);
            listView1.Columns.Add("Homecontact", 100);
            listView1.Columns.Add("Homeaddress", 100);
           
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream fileStream11 = new FileStream(fname, FileMode.Append);
            CsvFileWriter astream1 = new CsvFileWriter(fileStream11);
            fileStream11.Close();
            FileStream fileStream = new FileStream(fname, FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(fileStream);
            List<string> arecord = new List<string>();
            
            while (aCsvFileReader.ReadRow(arecord))
            {
               
                if (textBox1.Text == arecord[2])
                {
                    MessageBox.Show("Same Contact no has Entered...........");
                    fileStream.Close();
                    return;
                } 
              
            }
            fileStream.Close();

            FileStream fileStream1 = new FileStream(fname, FileMode.Append);
            CsvFileWriter astream = new CsvFileWriter(fileStream1);
            List<string> arecord1 = new List<string>();
            arecord1.Add(savetextBox.Text);
            arecord1.Add(emailText.Text);
            arecord1.Add(textBox1.Text);
            arecord1.Add(homeContacttext.Text);
            arecord1.Add(homeaddressText.Text);

            astream.WriteRow(arecord1);
            fileStream1.Close();
 }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(fname, FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(fileStream);
            List<string> arecord = new List<string>();
           // aCsvFileReader.ReadRow(arecord);

            listView1.Items.Clear();
            while (aCsvFileReader.ReadRow(arecord))
            {
                ListViewItem itm = new ListViewItem(new string[] { arecord[0], arecord[1], arecord[2], arecord[3],arecord[4] });
                listView1.Items.Add(itm);
            }
            fileStream.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(fname, FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(fileStream);
            List<string> arecorde = new List<string>();
            int flag = 0;
            while (aCsvFileReader.ReadRow(arecorde))
            {
                     if (savetextBox.Text == arecorde[0] && emailText.Text == arecorde[1] && textBox1.Text == arecorde[2])
                     {
                         flag = 1;
                         break;
                     }
                     else
                     {
                         flag = 0;
                         continue;
                     }
            }
            if (flag == 1) 
                MessageBox.Show("Found This Name, Email and Contact No.");
            else 
                MessageBox.Show("NOT Found");

            fileStream.Close();
        }

        

   
    }
}
