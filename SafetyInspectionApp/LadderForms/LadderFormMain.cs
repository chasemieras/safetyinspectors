using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafetyInspectionApp
{
    public partial class LadderFormMain : Form
    {

        FormHelper formHelper = new FormHelper();

        public LadderFormMain()
        {
            InitializeComponent();
        }
        private void LadderFormMain_FormClosing(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void NextLadderFormButton_Click(object sender, EventArgs e)
        {
            formHelper.sendInfoToSheet(LadInspectGroup);
            Form nextLadderForm;
            nextLadderForm = new LadderForms.ConditionForm();
            formHelper.setUpForm(nextLadderForm, this);
        }
    }
}
