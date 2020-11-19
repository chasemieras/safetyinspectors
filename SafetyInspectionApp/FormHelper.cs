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
        GoogleSheetHelper.GoogleSheetHelper sheetHelper = new GoogleSheetHelper.GoogleSheetHelper();

        /// <summary>
        /// Sets up the next form that the program wants to pull up.
        /// </summary>
        /// <author>
        /// Chase Mieras
        /// </author>
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
        /// Sends the information from the given panel to the master Google Sheet using the GoogleSheetHelper
        /// </summary>
        /// <author>
        /// Chase Mieras
        /// </author>
        /// <param name="panel">Panel from the form that you want to send data from its controls </param>
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
        /// Sends the information from the given panel to the master Google Sheet using the GoogleSheetHelper
        /// </summary>
        /// <author>
        /// Chase Mieras
        /// </author>
        /// <param name="images">List of Images from the form that you want to send data from its controls </param>
        public void sendInfoToSheet(List<Image> images)
        {

            List<IList<Object>> recordsToSend = new List<IList<Object>>();
            IList<Object> objectsToSend = new List<Object>();

            int index = 0;
            foreach (Image image in images)
            {
                objectsToSend.Add(image);
                index++;
            }

            recordsToSend.Add(objectsToSend);
            sheetHelper.WriteToSheet(recordsToSend);
        }

        /// <summary>
        /// Takes the given regex and panel to find all the GroupBoxes in the panel that match the regex.
        /// </summary>
        /// <author>
        /// Chase Mieras
        /// </author>
        /// <typeparam name="TControlType">Controls of the Panel</typeparam>
        /// <param name="regexPattern">Regex that is used to find the control group that you want</param>
        /// <param name="panel">panel that may contain GroupBoxes</param>
        /// <returns>Any controls that match the regex passed in</returns>
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
        /// <author>
        /// Chase Mieras
        /// </author>
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
        /// Creates a yes/no/na grouping for every condition listed in the ladderConditionSetUp() method.
        /// </summary>
        /// <author>
        /// Chase Mieras
        /// </author>
        /// <param name="locationX">starting x postion</param>
        /// <param name="locationY">starting x postion</param>
        /// <param name="currentPanel">the Panel that the inputs will be added to</param>
        public void createSectionLadderCondition(int locationX, int locationY, Panel currentPanel)
        {
            ArrayList ladderParts = ladderConditionSetUp();
            int ladderLocationAddition = 75;

            for (int i = 0; i < ladderParts.Count; i++) 
            {
                RadioButton yesButton = new System.Windows.Forms.RadioButton();
                RadioButton noButton = new System.Windows.Forms.RadioButton();
                RadioButton naButton = new System.Windows.Forms.RadioButton();
                //PictureBox pictureBox = new System.Windows.Forms.PictureBox();
                Label label = new System.Windows.Forms.Label();
                GroupBox sectionGroup = new System.Windows.Forms.GroupBox();

                //
                //sectionGroup
                //
                sectionGroup.Controls.Add(label);
                sectionGroup.Controls.Add(yesButton);
                sectionGroup.Controls.Add(noButton);
                sectionGroup.Controls.Add(naButton);
                //sectionGroup.Controls.Add(pictureBox);
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

                currentPanel.Controls.Add(sectionGroup);
            }
        }
    }

}
