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

namespace Phone_Spam
{
    public partial class PhoneSpam : Form
    {
        public PhoneSpam()
        {
            InitializeComponent();
        }

        private void PhoneSpam_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTableAsTXT = new OpenFileDialog();
            openTableAsTXT.Filter = "Документ TXT (*.txt) |*.txt";
            if (openTableAsTXT.ShowDialog() == DialogResult.OK)
            {
                Input.Text = File.ReadAllText(openTableAsTXT.FileName, Encoding.Default);
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTable = new SaveFileDialog();
            saveTable.Filter = "Документ TXT (*.txt) |*.txt";
            if (saveTable.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(saveTable.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(file, Encoding.Default);
                    sw.Write(Input.Text);
                    sw.WriteLine();
                    sw.Close();
                }
                catch { }
            }
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
