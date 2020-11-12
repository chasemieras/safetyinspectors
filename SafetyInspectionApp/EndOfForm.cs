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

        FormHelper formHelper = new FormHelper();
        FormSettings formSettings = new FormSettings();

        public EndOfForm(FormSettings formSettings)
        {
            InitializeComponent();
            this.formSettings = formSettings;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formHelper.submitDataToGooleSheet(formSettings);
            this.Close();
        }

        private void EndOfForm_FormClosing(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void continButton_Click(object sender, EventArgs e)
        {
            Form selectedForm;
            selectedForm = new StarterForm(new FormSettings());
            formHelper.submitDataToGooleSheet(formSettings);
            formHelper.setUpForm(selectedForm, this);
        }
    }
}
