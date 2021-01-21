using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tomb_oszege_questionmark
{
    public partial class Form1 : Form
    {
        int[] tomb = null;

        public Form1()
        {
            InitializeComponent();
            numericUpDownElemenSzam.Maximum = int.MaxValue;
        }

        private void bevitelBtn_Click(object sender, EventArgs e)
        {
            tomb = new int[(int)numericUpDownElemenSzam.Value];

            for (int i = 0; i < tomb.Length; i++)
                using(AddElement addElement = new AddElement())
                    if (addElement.ShowDialog() == DialogResult.OK)
                        tomb[i] = addElement.value;
                    else
                        tomb[i] = 0;

            WriteToRichTextbox();
        }

        public void WriteToRichTextbox()
        {
            richTextBox1.Text = string.Join('\n', tomb) + "\nÖsszeg: "+ tomb.Sum().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tomb = null;
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
