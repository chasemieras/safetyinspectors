using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleSheetHelper;

namespace SafetyInspectionApp
{
    public partial class LadderFormMain : Form
    {

        FormHelper formHelper = new FormHelper();
        GoogleSheetHelper.GoogleSheetHelper sheetHelper = new GoogleSheetHelper.GoogleSheetHelper();

        public LadderFormMain()
        {
            InitializeComponent();
        }

        private void NextLadderFormButton_Click(object sender, EventArgs e)
        {
            Form nextLadderForm;

            List<IList<Object>> objNewRecords = new List<IList<Object>>();
            IList<Object> obj = new List<Object>();
            obj.Add(textBox2.Text);
            obj.Add(textBox1.Text);


            if (FiberglassRadioButton.Checked == true)
            {
                obj.Add("Fiber Glass");
            }
            else if (AluminumRadioButton.Checked == true)
            {
                obj.Add("Aluminum");
            }

            if (ExtensionRadioButton.Checked == true)
            {
                obj.Add("Extension");
                objNewRecords.Add(obj);
                nextLadderForm = new LadderForms.ExtensionLadder();
                formHelper.setUpForm(nextLadderForm, this);
            }
            else if (PodiumRadioButton.Checked == true || SetpLadderRadioButton.Checked == true)
            {
                if (PodiumRadioButton.Checked == true)
                {
                    obj.Add("Podium");
                    objNewRecords.Add(obj);
                }
                else if (SetpLadderRadioButton.Checked == true)
                {
                    obj.Add("StepLadder");
                    objNewRecords.Add(obj);
                }
                nextLadderForm = new StepAndPodiumLadder();
                formHelper.setUpForm(nextLadderForm, this);
            }

            sheetHelper.WriteToSheet(objNewRecords);


        }
    }
}
