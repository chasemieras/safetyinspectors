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
        GoogleSheetHelper.GoogleSheetHelper sheetHelper = new GoogleSheetHelper.GoogleSheetHelper();

        public LadderFormMain()
        {
            InitializeComponent();
        }

        private void NextLadderFormButton_Click(object sender, EventArgs e)
        {

            Form nextLadderForm;
            nextLadderForm = new LadderForms.ConditionForm();
            formHelper.setUpForm(nextLadderForm, this);

            List<IList<Object>> recordsToSend = new List<IList<Object>>();
            IList<Object> objectsToSend = new List<Object>();
            for (int i = 0; i < this.Controls.Count; i++) 
            {
                //if (this.Controls[i].OfType<RadioButton>) 
                //{ 
                //}
            }
            //objectsToSend.Add();
            //recordsToSend.Add(objectsToSend);

            sheetHelper.WriteToSheet(recordsToSend);

        }
    }
}
