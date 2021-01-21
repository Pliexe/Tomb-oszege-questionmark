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
            numericUpDownElemenSzam.Select(0, 1);
        }

        private void bevitelBtn_Click(object sender, EventArgs e)
        {
            tomb = new int[(int)numericUpDownElemenSzam.Value];

            for (int i = 0; i < tomb.Length; i++)
                using(AddElement addElement = new AddElement())
                {
                    DialogResult result = addElement.ShowDialog();

                    if (result == DialogResult.OK)
                        tomb[i] = addElement.value;
                    else if(result == DialogResult.Abort) {
                        tomb = null;
                        MessageBox.Show("Leálitva!");
                        break;
                    }
                     else   tomb[i] = 0;
                }

            if(tomb != null) WriteToRichTextbox();
        }

        public void WriteToRichTextbox()
        {
            richTextBox1.Clear();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectionFont = new Font("Segoe", 12);
            richTextBox1.SelectedText = "\n" + string.Join('\n', tomb) + "\n";

            richTextBox1.SelectionFont = new Font("Segoe", 15);
            richTextBox1.SelectedText = "Összeg: " + tomb.Sum().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tomb = null;
            richTextBox1.Clear();
            numericUpDownElemenSzam.Value = 1;
            numericUpDownElemenSzam.Focus();
            numericUpDownElemenSzam.Select(0, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
