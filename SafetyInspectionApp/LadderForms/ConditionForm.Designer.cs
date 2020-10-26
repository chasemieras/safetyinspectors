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
            this.NextButtonExten = new System.Windows.Forms.Button();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.mainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButtonExten
            // 
            this.NextButtonExten.Location = new System.Drawing.Point(64, 333);
            this.NextButtonExten.Name = "NextButtonExten";
            this.NextButtonExten.Size = new System.Drawing.Size(297, 23);
            this.NextButtonExten.TabIndex = 3;
            this.NextButtonExten.Text = "Next";
            this.NextButtonExten.UseVisualStyleBackColor = true;
            this.NextButtonExten.Click += new System.EventHandler(this.NextButtonExten_Click);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.NextButtonExten);
            this.mainGroupBox.Location = new System.Drawing.Point(123, 12);
            this.mainGroupBox.MaximumSize = new System.Drawing.Size(440, 450);
            this.mainGroupBox.MinimumSize = new System.Drawing.Size(440, 450);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(440, 450);
            this.mainGroupBox.TabIndex = 4;
            this.mainGroupBox.TabStop = false;
            // 
            // ConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 477);
            this.Controls.Add(this.mainGroupBox);
            this.Name = "ConditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtensionLadder";
            this.Load += new System.EventHandler(this.ExtensionLadder_Load);
            this.mainGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NextButtonExten;
        private System.Windows.Forms.GroupBox mainGroupBox;
    }
}