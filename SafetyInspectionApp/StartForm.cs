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

            SafetyInspectForm.Size = new System.Drawing.Size(formSettings.FORM_WIDTH, formSettings.FORM_HEIGHT);

            Application.Run(SafetyInspectForm);

        }
    }
}
