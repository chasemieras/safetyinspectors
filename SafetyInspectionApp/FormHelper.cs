using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SafetyInspectionApp
{
    public class FormHelper
    {
        int ladderLocationAddition = 75;
        GoogleSheetHelper.GoogleSheetHelper sheetHelper = new GoogleSheetHelper.GoogleSheetHelper();

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

            nextForm.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            nextForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            nextForm.ClientSize = new System.Drawing.Size(800, 450);
            nextForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            nextForm.Text = "Safety Inspection Form";

            nextForm.Visible = true;

            previousForm.Visible = false;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="panel"></param>
        public void sendInfoToSheet(Panel panel)
        {

            List<IList<Object>> recordsToSend = new List<IList<Object>>();
            IList<Object> objectsToSend = new List<Object>();

            var sectionGroups = FindByPattern<GroupBox>(@"\S*Group\b", panel);

            foreach (GroupBox gb in sectionGroups) 
            {

                foreach (RadioButton rb in gb.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked) 
                    {
                        objectsToSend.Add(rb.Text);
                    }
                }

                foreach (TextBox tb in gb.Controls.OfType<TextBox>())
                {
                    objectsToSend.Add(tb.Text);
                }
            }

            recordsToSend.Add(objectsToSend);
            sheetHelper.WriteToSheet(recordsToSend);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TControlType"></typeparam>
        /// <param name="regexPattern"></param>
        /// <param name="form"></param>
        /// <returns></returns>
        public List<TControlType> FindByPattern<TControlType>(string regexPattern, Panel panel)
            where TControlType : Control
        {
            return panel.Controls.OfType<TControlType>()
                           .Where(control => Regex.IsMatch(control.Name, regexPattern))
                           .ToList();
        }

        /// <summary>
        /// Sets up the ladder parts by making an array of the parts
        /// </summary>
        /// <returns>an array list of ladder parts</returns>
        private ArrayList ladderConditionSetUp() {
            ArrayList ladderParts = new ArrayList();
            ladderParts.Add("steps");
            ladderParts.Add("rails");
            ladderParts.Add("labels");
            ladderParts.Add("platfrom");
            ladderParts.Add("top");
            ladderParts.Add("spreader");
            ladderParts.Add("rungs");
            ladderParts.Add("rails");
            ladderParts.Add("rung locks");
            ladderParts.Add("hardware");
            ladderParts.Add("shoes");
            ladderParts.Add("rope or pulley");
            ladderParts.Add("general");
            ladderParts.Add("other");

            return ladderParts;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="locationX"></param>
        /// <param name="locationY"></param>
        /// <param name="currentForm"></param>
        public void createSectionLadderCondition(int locationX, int locationY, Panel currentForm)
        {
            ArrayList ladderParts = ladderConditionSetUp();

            for (int i = 0; i < ladderParts.Count; i++) 
            {
                RadioButton yesButton = new System.Windows.Forms.RadioButton();
                RadioButton noButton = new System.Windows.Forms.RadioButton();
                RadioButton naButton = new System.Windows.Forms.RadioButton();
                Label label = new System.Windows.Forms.Label();
                GroupBox sectionGroup = new System.Windows.Forms.GroupBox();

                //
                //sectionGroup
                //
                sectionGroup.Controls.Add(label);
                sectionGroup.Controls.Add(yesButton);
                sectionGroup.Controls.Add(noButton);
                sectionGroup.Controls.Add(naButton);
                sectionGroup.Location = new System.Drawing.Point(locationX, locationY + ladderLocationAddition * i);
                sectionGroup.Name = (string)ladderParts[i] + "Group";
                sectionGroup.Size = new System.Drawing.Size(300, 80);

                // 
                // label
                // 
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(5, 20);
                label.Name = (string)ladderParts[i] + "Label";
                label.Size = new System.Drawing.Size(38, 25);
                label.TabIndex = 3;

                Regex rxEndsInS = new Regex(@"\S*s\b");
                Regex rxGeneral = new Regex(@"(?!\s*$)(?:general)+");
                Regex rxOther = new Regex(@"(?!\s*$)(?:other)+");

                if (rxEndsInS.IsMatch((string)ladderParts[i]))
                {
                    label.Text = "Are the " + ladderParts[i] + " in good condition?";
                }
                else if (rxGeneral.IsMatch((string)ladderParts[i]))
                {
                    label.Text = "Is there rust or corrosion on the ladder?";
                }
                else if (rxOther.IsMatch((string)ladderParts[i]))
                {
                    label.Text = "Are there any other issues with the ladder?";
                }
                else
                {
                    label.Text = "Is the " + (string)ladderParts[i] + " in good condition?";
                }

                // 
                // yesButton
                // 
                yesButton.AutoSize = true;
                yesButton.Location = new System.Drawing.Point(5, 35);
                yesButton.Name = (string)ladderParts[i] + "Yes";
                yesButton.Size = new System.Drawing.Size(94, 19);
                yesButton.TabIndex = 1;
                yesButton.TabStop = true;
                yesButton.Text = "Yes";
                yesButton.UseVisualStyleBackColor = true;

                // 
                // noButton
                // 
                noButton.AutoSize = true;
                noButton.Location = new System.Drawing.Point(50, 35);
                noButton.Name = (string)ladderParts[i] + "No";
                noButton.Size = new System.Drawing.Size(94, 19);
                noButton.TabIndex = 2;
                noButton.TabStop = true;
                noButton.Text = "No";
                noButton.UseVisualStyleBackColor = true;

                // 
                // naButton
                // 
                naButton.AutoSize = true;
                naButton.Location = new System.Drawing.Point(95, 35);
                naButton.Name = (string)ladderParts[i] + "NA";
                naButton.Size = new System.Drawing.Size(94, 19);
                naButton.TabIndex = 2;
                naButton.TabStop = true;
                naButton.Text = "N/A";
                naButton.UseVisualStyleBackColor = true;

                currentForm.Controls.Add(sectionGroup);
            }
        }
    }

}
