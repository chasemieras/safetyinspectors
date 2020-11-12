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
        FormSettings formSettings = new FormSettings();

        public LadderFormMain(FormSettings formSettings)
        {
            InitializeComponent();
            this.formSettings = formSettings;
        }
        private void LadderFormMain_FormClosing(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void NextLadderFormButton_Click(object sender, EventArgs e)
        {
            formHelper.storeInfoToSendToSheet(LadInspectGroup, formSettings);
            Form nextLadderForm;
            nextLadderForm = new LadderForms.ConditionForm(formSettings);
            formHelper.setUpForm(nextLadderForm, this);
        }
    }
}
