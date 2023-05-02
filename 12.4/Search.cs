using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _12._4
{
    public partial class Search : Form
    {
        public Form1 frm;
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] astrFiles = Directory.GetFiles(textBox1.Text);
            int count = 0;
            foreach (string file in astrFiles)
            {
                if (file.IndexOf(textBox2.Text) != -1)
                {
                    count++;
                }                   
            }
            listBox1.Items.Add("Всего файлов: " + count);
            foreach (string file in astrFiles)
            {
                if (file.IndexOf(textBox2.Text) != -1)
                {
                    listBox1.Items.Add(file);
                }                   
            }
        }
    }
}
