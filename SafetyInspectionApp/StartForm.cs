using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafetyInspectionApp
{
    static class StartForm
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form SafetyInspectForm = new StarterForm();
            //TO DO - Make main form to load this

            SafetyInspectForm.MinimizeBox = false;
            SafetyInspectForm.MaximizeBox = false;

            FormSettings formSettings = new FormSettings();

            SafetyInspectForm.MinimumSize = new System.Drawing.Size(formSettings.FORM_MIN_WIDTH, formSettings.FORM_HEIGHT);
            SafetyInspectForm.MaximumSize = new System.Drawing.Size(formSettings.FORM_MAX_WIDTH, formSettings.FORM_HEIGHT);

            //SafetyInspectForm.WindowState = FormWindowState.Maximized;

            Application.Run(SafetyInspectForm);

        }
    }
}
