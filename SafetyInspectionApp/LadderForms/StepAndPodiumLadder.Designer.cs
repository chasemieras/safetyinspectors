namespace SafetyInspectionApp
{
    partial class StepAndPodiumLadder
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
            this.NextButtonStepPod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextButtonStepPod
            // 
            this.NextButtonStepPod.Location = new System.Drawing.Point(12, 415);
            this.NextButtonStepPod.Name = "NextButtonStepPod";
            this.NextButtonStepPod.Size = new System.Drawing.Size(291, 23);
            this.NextButtonStepPod.TabIndex = 10;
            this.NextButtonStepPod.Text = "Next";
            this.NextButtonStepPod.UseVisualStyleBackColor = true;
            // 
            // StepAndPodiumLadder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextButtonStepPod);
            this.Name = "StepAndPodiumLadder";
            this.Text = "Safety Inspection Form";
            this.Load += new System.EventHandler(this.StepAndPodiumLadder_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NextButtonStepPod;
    }
}