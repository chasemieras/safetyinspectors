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

        private void NextLadderFormButton_Click(object sender, EventArgs e)
        {

            Form nextLadderForm;


            if (ExtensionRadioButton.Checked == true)
            {
                nextLadderForm = new LadderForms.ExtensionLadder();
                formHelper.setUpForm(nextLadderForm, this);
            }
            else if (PodiumRadioButton.Checked == true || SetpLadderRadioButton.Checked == true)
            {
                nextLadderForm = new StepAndPodiumLadder();
                formHelper.setUpForm(nextLadderForm, this);
            }
        }
    }
}
