using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SafetyInspectionApp.LadderForms
{
    public partial class ExtensionLadder : Form
    {
       
        FormHelper formHelper = new FormHelper();

        public ExtensionLadder()
        {
            InitializeComponent();
        }

        private void NextButtonExten_Click(object sender, EventArgs e)
        {

        }

        private void ExtensionLadder_Load(object sender, EventArgs e)
        {
            int locationX = 0;
            int locationY = 0;
            int locationAddition = 60;

            Panel conditionGroup = new System.Windows.Forms.Panel();
            conditionGroup.Location = new System.Drawing.Point(locationX, locationY);
            conditionGroup.Name = "conditionSection";
            conditionGroup.Size = new System.Drawing.Size(this.Width / 3, this.Height / 2);
            conditionGroup.AutoScroll = true;
            conditionGroup.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(conditionGroup);

            formHelper.createConditionSection("rungs", locationX, locationY + locationAddition * 0, conditionGroup);
            formHelper.createConditionSection("rails", locationX, locationY + locationAddition * 1, conditionGroup);
            formHelper.createConditionSection("labels", locationX, locationY + locationAddition * 2, conditionGroup);
            formHelper.createConditionSection("rung locks", locationX, locationY + locationAddition * 3, conditionGroup);
            formHelper.createConditionSection("hardware", locationX, locationY + locationAddition * 4, conditionGroup);
            formHelper.createConditionSection("shoes", locationX, locationY + locationAddition * 5, conditionGroup);
            formHelper.createConditionSection("rope or pulley", locationX, locationY + locationAddition * 5, conditionGroup);
            formHelper.createConditionSection("general", locationX, locationY + locationAddition * 6, conditionGroup);
            formHelper.createConditionSection("other", locationX, locationY + locationAddition * 7, conditionGroup);
        }
    }
}
