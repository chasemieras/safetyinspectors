using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SafetyInspectionApp
{
    public partial class StarterForm : Form
    {

        FormHelper formHelper = new FormHelper();
        public StarterForm()
        {
            InitializeComponent();
        }

        private void MainNextButton_Click(object sender, EventArgs e)
        {
            Form selectedForm;
            if (LadderForm.Checked == true)
            {
                selectedForm = new LadderFormMain();
                formHelper.setUpForm(selectedForm, this);
            }
        }
    }
}
