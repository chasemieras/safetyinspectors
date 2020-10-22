using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GoogleSheetHelper;

namespace SafetyInspectionApp
{
    public partial class StarterForm : Form
    {

        FormHelper formHelper = new FormHelper();
        GoogleSheetHelper.GoogleSheetHelper sheetHelper = new GoogleSheetHelper.GoogleSheetHelper();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.label3.Text= sheetHelper.findThis("A1:F24", "Andrew", 6)[0];

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
