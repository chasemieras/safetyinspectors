namespace SafetyInspectionApp.LadderForms
{
    partial class ExtensionLadder
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
            this.SuspendLayout();
            // 
            // NextButtonExten
            // 
            this.NextButtonExten.Location = new System.Drawing.Point(12, 415);
            this.NextButtonExten.Name = "NextButtonExten";
            this.NextButtonExten.Size = new System.Drawing.Size(297, 23);
            this.NextButtonExten.TabIndex = 3;
            this.NextButtonExten.Text = "Next";
            this.NextButtonExten.UseVisualStyleBackColor = true;
            this.NextButtonExten.Click += new System.EventHandler(this.NextButtonExten_Click);
            // 
            // ExtensionLadder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextButtonExten);
            this.Name = "ExtensionLadder";
            this.Text = "ExtensionLadder";
            this.Load += new System.EventHandler(this.ExtensionLadder_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NextButtonExten;
    }
}