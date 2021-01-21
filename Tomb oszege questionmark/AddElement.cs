using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tomb_oszege_questionmark
{
    public partial class AddElement : Form
    {
        public int value;

        public AddElement()
        {
            InitializeComponent();
            numericUpDown1.Minimum = int.MinValue;
            numericUpDown1.Maximum = int.MaxValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = (int)numericUpDown1.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
