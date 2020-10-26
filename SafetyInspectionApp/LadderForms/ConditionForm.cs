using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SafetyInspectionApp.LadderForms
{
    public partial class ConditionForm : Form
    {
       
        FormHelper formHelper = new FormHelper();

        public ConditionForm()
        {
            InitializeComponent();
        }

        private void NextButtonExten_Click(object sender, EventArgs e)
        {
            Form closeForm;
            closeForm = new EndOfForm();
            formHelper.setUpForm(closeForm, this);
        }

        private void ExtensionLadder_Load(object sender, EventArgs e)
        {
            int locationX = 10;
            int locationY = 20;

            Panel conditionGroup = new System.Windows.Forms.Panel();
            conditionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            conditionGroup.Location = new System.Drawing.Point(locationX, locationY);
            conditionGroup.Name = "conditionSection";
            conditionGroup.Size = new System.Drawing.Size(mainGroupBox.Width - 20 , mainGroupBox.Height / 2);
            conditionGroup.AutoScroll = true;
            conditionGroup.BorderStyle = BorderStyle.FixedSingle;
            mainGroupBox.Controls.Add(conditionGroup);

            formHelper.createSectionLadderCondition(locationX, locationY, conditionGroup);
        }
    }
}
