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
        Panel conditionGroup = new System.Windows.Forms.Panel();

        public ConditionForm()
        {
            InitializeComponent();
        }

        private void NextButtonExten_Click(object sender, EventArgs e)
        {
            Form closeForm;
            closeForm = new EndOfForm();
            formHelper.sendInfoToSheet(conditionGroup);
            formHelper.setUpForm(closeForm, this);
        }

        private void ExtensionLadder_Load(object sender, EventArgs e)
        {
            int locationX = 10;
            int locationY = 20;

            conditionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            conditionGroup.Location = new System.Drawing.Point(locationX, locationY);
            conditionGroup.Name = "conditionSection";
            conditionGroup.Size = new System.Drawing.Size(Group.Width - 20 , Group.Height / 2);
            conditionGroup.AutoScroll = true;
            conditionGroup.BorderStyle = BorderStyle.FixedSingle;
            Group.Controls.Add(conditionGroup);

            formHelper.createSectionLadderCondition(locationX, locationY, conditionGroup);
        }
    }
}
