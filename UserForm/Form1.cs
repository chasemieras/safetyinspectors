using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Mark Beebe
namespace UserForm
{
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LadderTypeGroupBox_Enter(object sender, EventArgs e)
        {
            if (LadderTypeGroupBox.Equals("Extension"))
            {
                ExtensionConditionsGroupBox.Visible = true;
                LadderConditionsGroupBox.Visible = false;
            } else if (LadderTypeGroupBox.Equals("Step Ladder"))
            {
                ExtensionConditionsGroupBox.Visible = false;
                LadderConditionsGroupBox.Visible = true;
            } else if (LadderTypeGroupBox.Equals("Podium"))
            {
                ExtensionConditionsGroupBox.Visible = false;
                LadderConditionsGroupBox.Visible = true;
            }
        }
    }
}
