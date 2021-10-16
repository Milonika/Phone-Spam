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
        private string filePath;
        private string fileContent;
        private List<string> lst = new List<string>();
        public PhoneSpam()
        {
            InitializeComponent();
        }

        private void PhoneSpam_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTable = new SaveFileDialog();
            saveTable.Filter = "Документ TXT (*.txt) |*.txt";
            if (saveTable.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(saveTable.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(file, Encoding.Default);
                    sw.Write(ResultTable.Text);
                    sw.WriteLine();
                    sw.Close();
                }
                catch { }
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTableAsTXT = new OpenFileDialog();
            openTableAsTXT.Filter = "Документ TXT (*.txt) |*.txt";
            if (openTableAsTXT.ShowDialog() == DialogResult.OK)
            {
                Input.Text = File.ReadAllText(openTableAsTXT.FileName, Encoding.Default);
            }
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }


        private void report_Click(object sender, EventArgs e)
        {
            string[] arr = Input.Text.Split('\n');
            List<string> telephones = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                telephones.Add(arr[i]);
            }
            telephones.RemoveAt(telephones.Count - 1);
            int count = 1;
            for (int i = 0; i < telephones.Count; i++)
            {
                for (int item = 1; item < arr.Length; item++)
                {
                    if (arr[i] != "" && arr[item] != "")
                    {
                        if (arr[i].Substring(0, 11) == arr[item].Substring(0, 11))
                        {
                            count++;
                            telephones.Remove(arr[item]);
                        }
                    }
                }
                ResultTable.Text += $"{ParsingString(arr[i], count)}, \n";
                count = 1;
            }

        }
        private string ParsingString(string str, int count)
        {
            try
            {
                return $"{str.Substring(0, 11)}, {count}, {str.Substring(41, 7)}";
            }
            catch
            {
                return "";
            }
        }

        private void ResultTable_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
