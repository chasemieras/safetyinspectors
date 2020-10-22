using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SafetyInspectionApp
{
    public partial class StepAndPodiumLadder : Form
    {

        FormHelper formHelper = new FormHelper();

        public StepAndPodiumLadder()
        {
            InitializeComponent();
        }

        private void StepAndPodiumLadder_Load(object sender, EventArgs e)
        {
            int locationX = 0;
            int locationY = 0;
            int locationAddition = 60;

            Panel conditionGroup = new System.Windows.Forms.Panel();
            conditionGroup.Location = new System.Drawing.Point(locationX, locationY);
            conditionGroup.Name = "conditionSection";
            conditionGroup.Size = new System.Drawing.Size(this.Width/3, this.Height/2);
            conditionGroup.AutoScroll = true;
            conditionGroup.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(conditionGroup);

            formHelper.createYesNoSectionCondition("steps", locationX, locationY + locationAddition * 0, conditionGroup);
            formHelper.createYesNoSectionCondition("rails", locationX, locationY + locationAddition * 1, conditionGroup);
            formHelper.createYesNoSectionCondition("labels", locationX, locationY + locationAddition * 2, conditionGroup);
            formHelper.createYesNoSectionCondition("platform", locationX, locationY + locationAddition * 3, conditionGroup);
            formHelper.createYesNoSectionCondition("top", locationX, locationY + locationAddition * 4, conditionGroup);
            formHelper.createYesNoSectionCondition("spreader", locationX, locationY + locationAddition * 5, conditionGroup);
            formHelper.createYesNoSectionCondition("general", locationX, locationY + locationAddition * 6, conditionGroup);
            formHelper.createYesNoSectionCondition("other", locationX, locationY + locationAddition * 7, conditionGroup);

        }

    }
}
