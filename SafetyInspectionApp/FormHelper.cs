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

        private FormSettings formSettings = new FormSettings();
        private GoogleSheetHelper sheetHelper = new GoogleSheetHelper();

        /// <summary>
        /// <para>Author: Chase Mieras</para>
        /// Sets up the next form that the program wants to pull up.
        /// </summary>
        /// <param name="nextForm"> The next for that will be shown </param>
        /// <param name="previousForm"> The previous form that will be hidden </param>
        public void setUpForm(Form nextForm, Form previousForm)
        {
            nextForm.MinimizeBox = false;
            nextForm.MaximizeBox = false;

            nextForm.MinimizeBox = false;
            nextForm.MaximizeBox = false;

            nextForm.Size = new System.Drawing.Size(formSettings.FORM_WIDTH, formSettings.FORM_HEIGHT);

            nextForm.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            nextForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            nextForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            nextForm.Text = "Safety Inspection Form";

            nextForm.Visible = true;

            previousForm.Visible = false;

        }

        /// <summary>
        /// <para>Author: Chase Mieras</para>
        /// Stores the data that will be sent to the Google Sheet
        /// </summary>
        /// <param name="panel">Panel from the form that you want to send data from its controls </param>
        /// <param name="dataStorage"></param>
        public void storeInfoToSendToSheet(Panel panel, FormSettings dataStorage)
        {

            IList<Object> controlsDataList = dataStorage.controlsDataList;

            var sectionGroups = findByPattern<GroupBox>(@"\S*Group\b", panel);

            foreach (GroupBox gb in sectionGroups)
            {

                foreach (RadioButton rb in gb.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked)
                    {
                        controlsDataList.Add(rb.Name + ": " + true);
                    }
                    else
                    {
                        controlsDataList.Add(rb.Name + ": " + false);
                    }
                }

                foreach (TextBox tb in gb.Controls.OfType<TextBox>())
                {
                    if (tb.Text != null || tb.Text != "")
                    {
                        controlsDataList.Add(tb.Name + ": " + tb.Text);
                    }
                    else
                    {
                        controlsDataList.Add(tb.Name + ": n/a");
                    }
                }
            }
        }

        /// <summary>
        /// <para>Author: Chase Mieras</para>
        /// Submits the stored data in dataToSendFromControlList to the master Google Sheet
        /// </summary>
        /// <param name="dataStorage">formSetting that has all the data</param>
        public void submitDataToGooleSheet(FormSettings dataStorage)
        {
            List<IList<Object>> dataToSendFromControlList = new List<IList<Object>>();
            dataToSendFromControlList.Add(dataStorage.controlsDataList);

            sheetHelper.WriteToSheet(dataToSendFromControlList);
        }

        /// <summary>
        /// <para>Author: Chase Mieras</para>
        /// Specifc method for the starter form to use when submitting data for the Google Sheet
        /// </summary>
        /// <param name="starterForm">The starter form</param>
        /// <param name="formSettings"></param>
        public void starterNextForm(StarterForm starterForm, FormSettings formSettings)
        {
            Form selectedForm;
            selectedForm = new LadderFormMain(formSettings);
            setUpForm(selectedForm, starterForm);

            IList<Object> controlsDataList = formSettings.controlsDataList;

            foreach (TextBox tb in starterForm.Controls.OfType<TextBox>())
            {
                controlsDataList.Add(tb.Text);
            }

            controlsDataList.Add(DateTime.Now);
        }

        /// <summary>
        /// <para>Author: Chase Mieras</para>
        /// Takes the given regex and panel to find all the GroupBoxes in the panel that match the regex.
        /// </summary>
        /// <typeparam name="TControlType">Controls of the Panel</typeparam>
        /// <param name="regexPattern">Regex that is used to find the control group that you want</param>
        /// <param name="panel">panel that may contain GroupBoxes</param>
        /// <returns>Any controls that match the regex passed in</returns>
        public List<TControlType> findByPattern<TControlType>(string regexPattern, Panel panel)
            where TControlType : Control
        {
            return panel.Controls.OfType<TControlType>()
                           .Where(control => Regex.IsMatch(control.Name, regexPattern))
                           .ToList();
        }

        /// <summary>
        /// <para>Author: Chase Mieras</para>
        /// Sets up the ladder parts by making an array of the parts
        /// </summary>
        /// <returns>an array list of ladder parts</returns>
        private ArrayList ladderConditionSetUp()
        {
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
        /// Author: Chase Mieras
        /// </summary>
        /// <param name="locationX">starting x postion</param>
        /// <param name="locationY">starting x postion</param>
        /// <param name="currentPanel">the Panel that the inputs will be added to</param>
        public void createSectionLadderCondition(int locationX, int locationY, Panel currentPanel)
        {
            ArrayList ladderParts = ladderConditionSetUp();
            int ladderLocationAddition = 100;

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
                sectionGroup.Size = new System.Drawing.Size(300, 100);

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
                yesButton.CheckedChanged += (sender, EventArgs) => { yesOrNoPressed(sender, EventArgs, sectionGroup); };

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
                noButton.CheckedChanged += (sender, EventArgs) => { yesOrNoPressed(sender, EventArgs, sectionGroup); };

                // 
                // naButton
                // 
                naButton.AutoSize = true;
                naButton.Location = new System.Drawing.Point(95, 35);
                naButton.Name = (string)ladderParts[i] + "NA";
                naButton.Size = new System.Drawing.Size(94, 19);
                naButton.TabIndex = 3;
                naButton.TabStop = true;
                naButton.Text = "N/A";
                naButton.UseVisualStyleBackColor = true;

                currentPanel.Controls.Add(sectionGroup);
            }
        }

        /// <summary>
        /// <para>Author: Mark Beebe</para>
        /// Creates comment section(label and textbox) if yes or no is pressed.
        /// </summary>
        public void yesOrNoPressed(object sender, EventArgs e, GroupBox sectionGroup)
        {
            Label commentsTextBoxLabel = new System.Windows.Forms.Label();
            TextBox commentsTextBox = new System.Windows.Forms.TextBox();

            //
            //commentsTextBoxLabel
            //
            commentsTextBoxLabel.AutoSize = true;
            commentsTextBoxLabel.Location = new System.Drawing.Point(5, 70);
            commentsTextBoxLabel.Name = sectionGroup.Name + "commentsTextBoxLabel";
            commentsTextBoxLabel.Size = new System.Drawing.Size(94, 19);
            commentsTextBoxLabel.TabIndex = 4;
            commentsTextBoxLabel.TabStop = true;
            commentsTextBoxLabel.Text = "Comments: ";
            commentsTextBoxLabel.Visible = true;

            //
            //commentsTextBox
            //
            commentsTextBox.AutoSize = true;
            commentsTextBox.Location = new System.Drawing.Point(80, 65);
            commentsTextBox.Size = new System.Drawing.Size(210, 23);
            commentsTextBox.Name = sectionGroup.Name + "commentsTextBox";
            commentsTextBox.TabIndex = 5;
            commentsTextBox.TabStop = true;
            commentsTextBox.Visible = true;

            foreach (RadioButton rb in sectionGroup.Controls.OfType<RadioButton>())
            {
                if ((rb.Checked && rb.Text.Contains("No")))
                {
                    sectionGroup.Controls.Add(commentsTextBoxLabel);
                    sectionGroup.Controls.Add(commentsTextBox);

                }
                else if (rb.Checked && rb.Text.Contains("Yes") || rb.Checked && rb.Text.Contains("N/A"))
                {
                    if (sectionGroup.Controls.Contains(commentsTextBoxLabel)) 
                    {
                        sectionGroup.Controls.Remove(commentsTextBoxLabel);
                        sectionGroup.Controls.Remove(commentsTextBox);
                    }
                }

            }
        }

        /// <summary>
        /// <para>Author: Mark Beebe</para>
        /// Checks every group box in the form(which represents each question)
        /// to make sure a radio button has been checked. If there are any group boxes that do
        /// not have a selection, returns false
        /// </summary>
        public Boolean validateRadioButtons(Panel panel)
        {
            var sectionGroups = findByPattern<GroupBox>(@"\S*Group\b", panel);

            Boolean passed = false;
            foreach (GroupBox gb in sectionGroups)
            {
                foreach (RadioButton rb in gb.Controls.OfType<RadioButton>())
                {
                    if (rb.Checked)
                    {
                        passed = true;
                        break;
                    }
                    else
                    {
                        passed = false;

                    }
                }
                if (passed == false)
                {
                    return false;
                }
            }
            return passed;
        }
    }

}
