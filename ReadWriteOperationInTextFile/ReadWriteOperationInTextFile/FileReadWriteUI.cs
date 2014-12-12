using System;
using System.IO;
using System.Windows.Forms;

namespace ReadWriteOperationInTextFile
{
    public partial class FileReadWriteUI : Form
    {
        private string fileLocation = @"studentname.txt";
        public FileReadWriteUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(nameTextBox.Text);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            namesListBox.Items.Clear();
            while (!aStreamReader.EndOfStream)
            {
                string aLine = aStreamReader.ReadLine();
                namesListBox.Items.Add(aLine);
            }
            aStreamReader.Close();
        }

    }
}
