namespace SafetyInspectionApp.LadderForms
{
    partial class ConditionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConditionForm));
            this.NextButtonExten = new System.Windows.Forms.Button();
            this.Group = new System.Windows.Forms.Panel();
            this.Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButtonExten
            // 
            this.NextButtonExten.Location = new System.Drawing.Point(77, 365);
            this.NextButtonExten.Name = "NextButtonExten";
            this.NextButtonExten.Size = new System.Drawing.Size(297, 23);
            this.NextButtonExten.TabIndex = 3;
            this.NextButtonExten.Text = "Next";
            this.NextButtonExten.UseVisualStyleBackColor = true;
            this.NextButtonExten.Click += new System.EventHandler(this.NextButtonExten_Click);
            // 
            // Group
            // 
            this.Group.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Group.Controls.Add(this.NextButtonExten);
            this.Group.Location = new System.Drawing.Point(102, 12);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(461, 423);
            this.Group.TabIndex = 5;
            // 
            // ConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 477);
            this.Controls.Add(this.Group);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtensionLadder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConditionForm_FormClosing);
            this.Load += new System.EventHandler(this.ExtensionLadder_Load);
            this.Group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NextButtonExten;
        private System.Windows.Forms.Panel Group;
    }
}