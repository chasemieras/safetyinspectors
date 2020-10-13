using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafetyInspectionApplication
{
    public partial class ExtensionLadderForm : Form
    {
        public ExtensionLadderForm()
        {
            InitializeComponent();
        }

        private void ExtensionLadderForm_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
