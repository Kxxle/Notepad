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

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files(.txt) | *.txt";
            openFileDialog1.Multiselect = false;
            openFileDialog1.DefaultExt = "txt";

            DialogResult dialogResult1 = openFileDialog1.ShowDialog();
            if(dialogResult1 == DialogResult.OK)
            {
                String filepath=openFileDialog1.FileName;
                FileStream fileStream1 = new FileStream(filepath, FileMode.Open,FileAccess.Read);
                StreamReader streamReader1 = new StreamReader(fileStream1);
                textBox1 .Text = streamReader1.ReadToEnd();

                streamReader1 .Close();
                fileStream1 .Close();
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
            toolStripStatusLabel1.Text = $"Characters: {textBox1.Text.Length}";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files | *.txt";
            saveFileDialog1.DefaultExt = "txt";

            DialogResult dialogResult = saveFileDialog1.ShowDialog(); 
            if (dialogResult == DialogResult.OK)
            {
                String filepath = saveFileDialog1.FileName;
                FileStream fileStream1 = new FileStream(filepath,FileMode.CreateNew,FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream1);
                streamWriter.Write(textBox1.Text);
                streamWriter.Close();
                fileStream1 .Close();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            
            DialogResult dialogResult = fontDialog1.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                textBox1 .Font = fontDialog1.Font;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            DialogResult dialogResult = colorDialog1.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files(.txt) | *.txt";
            openFileDialog1.Multiselect = false;
            openFileDialog1.DefaultExt = "txt";

            DialogResult dialogResult1 = openFileDialog1.ShowDialog();
            if (dialogResult1 == DialogResult.OK)
            {
                String filepath = openFileDialog1.FileName;
                FileStream fileStream1 = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                StreamReader streamReader1 = new StreamReader(fileStream1);
                textBox1.Text = streamReader1.ReadToEnd();

                streamReader1.Close();
                fileStream1.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files | *.txt";
            saveFileDialog1.DefaultExt = "txt";

            DialogResult dialogResult = saveFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                String filepath = saveFileDialog1.FileName;
                FileStream fileStream1 = new FileStream(filepath, FileMode.CreateNew, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream1);
                streamWriter.Write(textBox1.Text);
                streamWriter.Close();
                fileStream1.Close();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();

            DialogResult dialogResult = fontDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
