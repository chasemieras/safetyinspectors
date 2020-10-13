using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafetyInspectionApplication
{
    public partial class MainForm : Form
    {
       

        public MainForm()
        {
            InitializeComponent();

        }

  

        private void NextFormButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            if (extensionLadderButton.Checked == true)
            {
                ExtensionLadderForm extensionForm = new ExtensionLadderForm();
                extensionForm.Visible = true;
            }
            else if (podiumButton.Checked == true || stepLadderButton.Checked == true)
            {
                StepAndPodiumForm stepAndPodiumForm = new StepAndPodiumForm();
                stepAndPodiumForm.Visible = true;
            }
            else
            {
                Console.WriteLine("missing ladder type");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
