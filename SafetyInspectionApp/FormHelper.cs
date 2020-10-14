using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
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
    }
}
