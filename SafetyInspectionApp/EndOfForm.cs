using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SafetyInspectionApp
{
    public partial class EndOfForm : Form
    {
        public EndOfForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EndOfForm_FormClosing(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
