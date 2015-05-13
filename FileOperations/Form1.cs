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

namespace FileOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string path = @"E:\103407\02052015\FileOperations\text.txt";
            FileStream aFileStream=new FileStream (path, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.WriteLine(nameTextBox.Text);
            aStreamWriter.Close();
            aFileStream.Close();
            nameTextBox.Clear();
        }
    }
}
