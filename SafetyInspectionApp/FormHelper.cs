using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SafetyInspectionApp
{
    public class FormHelper
    {
        /// <summary>
        /// Sets up the next form that the program wants to pull up.
        /// </summary>
        /// <param name="nextForm"> The next for that will be shown </param>
        /// <param name="previousForm"> The previous form that will be hidden </param>
        public void setUpForm(Form nextForm, Form previousForm) 
        {
            nextForm.MinimizeBox = false;
            nextForm.MaximizeBox = false;

            FormSettings formSettings = new FormSettings();

            nextForm.MinimumSize = new Size(formSettings.FORM_MIN_WIDTH, formSettings.FORM_HEIGHT);
            nextForm.MaximumSize = new Size(formSettings.FORM_MAX_WIDTH, formSettings.FORM_HEIGHT);
            nextForm.Visible = true;

            previousForm.Visible = false;
        }

        public void createYesNoSectionCondition(string sectionName, int locationX, int locationY, Panel currentForm)
        {
            RadioButton yesButton = new System.Windows.Forms.RadioButton();
            RadioButton noButton = new System.Windows.Forms.RadioButton();
            Label label = new System.Windows.Forms.Label();
            GroupBox sectionGroup = new System.Windows.Forms.GroupBox();

            //
            //sectionGroup
            //
            sectionGroup.Controls.Add(label);
            sectionGroup.Controls.Add(yesButton);
            sectionGroup.Controls.Add(noButton);
            sectionGroup.Location = new System.Drawing.Point(locationX, locationY);
            sectionGroup.Name = sectionName + "Section";
            sectionGroup.Size = new System.Drawing.Size(250, 80);

            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(5, 20);
            label.Name = sectionName+"Label";
            label.Size = new System.Drawing.Size(38, 25);
            label.TabIndex = 3;

            Regex rxEndsInS = new Regex(@"\S*s\b");
            Regex rxGeneral = new Regex(@"(?!\s*$)(?:general)+");
            Regex rxOther = new Regex(@"(?!\s*$)(?:other)+");

            if (rxEndsInS.IsMatch(sectionName)) {
                label.Text = "Are the " + sectionName + " in good condition?";
            }
            else if (rxGeneral.IsMatch(sectionName)) 
            {
                label.Text = "Is there rust or corrosion on the ladder?";
            }
            else if (rxOther.IsMatch(sectionName))
            {
                label.Text = "Are there any other issues with the ladder?";
            }
            else
            {
                label.Text = "Is the " + sectionName + " in good condition?";
            }
            

            // 
            // yesButton
            // 
            yesButton.AutoSize = true;
            yesButton.Location = new System.Drawing.Point(5, 35);
            yesButton.Name = sectionName+"Yes";
            yesButton.Size = new System.Drawing.Size(94, 19);
            yesButton.TabIndex = 1;
            yesButton.TabStop = true;
            yesButton.Text = "Yes";
            yesButton.UseVisualStyleBackColor = true;

            // 
            // noButton
            // 
            noButton.AutoSize = true;
            noButton.Location = new System.Drawing.Point(5, 55);
            noButton.Name = sectionName + "No";
            noButton.Size = new System.Drawing.Size(94, 19);
            noButton.TabIndex = 2;
            noButton.TabStop = true;
            noButton.Text = "No";
            noButton.UseVisualStyleBackColor = true;

            currentForm.Controls.Add(sectionGroup);
        }
    }
}
