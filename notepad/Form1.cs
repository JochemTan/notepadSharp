using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        public string filename;
       
        

        public Form1()
        {
            InitializeComponent();
        }
        //comment van leon
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.Copy();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.Clear();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.SelectAll();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = " .txt| *.txt";
            System.IO.StreamReader openFile = new System.IO.StreamReader(openFileDialog1.FileName);
            // Reads the file from beginning to end and places the text inside the textbox
            textbox.Text = openFile.ReadToEnd();
            openFile.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            System.IO.StreamWriter savefile = new System.IO.StreamWriter(filename);
                savefile.WriteLine(textbox.Text);
                savefile.Close();
          
            MessageBox.Show("File Saved!");

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = " .txt| *.txt";
            saveFileDialog1.Title = "Save an Image File";


            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                this.filename = saveFileDialog1.FileName;
                System.IO.StreamWriter savefile = new System.IO.StreamWriter(saveFileDialog1.FileName);
                savefile.WriteLine(textbox.Text);
                savefile.Close();
            }
            else
            {
                MessageBox.Show("Please fill in a File name");
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.Undo();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontSizeBigToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fontSize = 32;
            textbox.Font = new Font(textbox.Font.FontFamily, fontSize);
        }

        private void smalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToInt32(textbox.Font.Size).ToString());
            int fontSize = 8;
            textbox.Font = new Font(textbox.Font.FontFamily,fontSize);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fontSize = 12;
            textbox.Font = new Font(textbox.Font.FontFamily, fontSize);
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int font = Convert.ToInt32(textbox.Font.Size);
            int newFont = font + 2;
            textbox.Font = new Font(textbox.Font.FontFamily, newFont);
        }

        private void manualSmallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int font = Convert.ToInt32(textbox.Font.Size);
            if (textbox.Font.Size > 4)
            {
                int newFont = font - 2;
                textbox.Font = new Font(textbox.Font.FontFamily, newFont);
            }
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.ForeColor = System.Drawing.Color.Black;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.ForeColor = System.Drawing.Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.ForeColor = System.Drawing.Color.Blue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.ForeColor = System.Drawing.Color.Green;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
