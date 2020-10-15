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
            this.LadderInspectionStepPod = new System.Windows.Forms.GroupBox();
            this.NextButtonStepPod = new System.Windows.Forms.Button();
            this.ActionStepPod = new System.Windows.Forms.GroupBox();
            this.GoodConditionStepLad = new System.Windows.Forms.RadioButton();
            this.RemoveLadderStepPod = new System.Windows.Forms.RadioButton();
            this.LadderConditionSetpPod = new System.Windows.Forms.GroupBox();
            this.OtherConditionStepPod = new System.Windows.Forms.CheckBox();
            this.StepsConditionStepPod = new System.Windows.Forms.CheckBox();
            this.GeneralConditionStepPod = new System.Windows.Forms.CheckBox();
            this.RailsConditionStepPod = new System.Windows.Forms.CheckBox();
            this.SpreaderConditionStepPod = new System.Windows.Forms.CheckBox();
            this.LabelsConditionStepPod = new System.Windows.Forms.CheckBox();
            this.TopConditionStepPod = new System.Windows.Forms.CheckBox();
            this.PlatformConditionStepPod = new System.Windows.Forms.CheckBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.LadderInspectionStepPod.SuspendLayout();
            this.ActionStepPod.SuspendLayout();
            this.LadderConditionSetpPod.SuspendLayout();
            this.SuspendLayout();
            // 
            // LadderInspectionStepPod
            // 
            this.LadderInspectionStepPod.Controls.Add(this.vScrollBar1);
            this.LadderInspectionStepPod.Controls.Add(this.NextButtonStepPod);
            this.LadderInspectionStepPod.Controls.Add(this.ActionStepPod);
            this.LadderInspectionStepPod.Controls.Add(this.LadderConditionSetpPod);
            this.LadderInspectionStepPod.Location = new System.Drawing.Point(215, 12);
            this.LadderInspectionStepPod.MinimumSize = new System.Drawing.Size(335, 380);
            this.LadderInspectionStepPod.Name = "LadderInspectionStepPod";
            this.LadderInspectionStepPod.Size = new System.Drawing.Size(335, 380);
            this.LadderInspectionStepPod.TabIndex = 0;
            this.LadderInspectionStepPod.TabStop = false;
            this.LadderInspectionStepPod.Text = "Ladder Inspection";
            // 
            // NextButtonStepPod
            // 
            this.NextButtonStepPod.Location = new System.Drawing.Point(25, 335);
            this.NextButtonStepPod.Name = "NextButtonStepPod";
            this.NextButtonStepPod.Size = new System.Drawing.Size(291, 23);
            this.NextButtonStepPod.TabIndex = 10;
            this.NextButtonStepPod.Text = "Next";
            this.NextButtonStepPod.UseVisualStyleBackColor = true;
            // 
            // ActionStepPod
            // 
            this.ActionStepPod.Controls.Add(this.GoodConditionStepLad);
            this.ActionStepPod.Controls.Add(this.RemoveLadderStepPod);
            this.ActionStepPod.Location = new System.Drawing.Point(19, 256);
            this.ActionStepPod.Name = "ActionStepPod";
            this.ActionStepPod.Size = new System.Drawing.Size(303, 73);
            this.ActionStepPod.TabIndex = 9;
            this.ActionStepPod.TabStop = false;
            this.ActionStepPod.Text = "Action to Take";
            // 
            // GoodConditionStepLad
            // 
            this.GoodConditionStepLad.AutoSize = true;
            this.GoodConditionStepLad.Location = new System.Drawing.Point(6, 49);
            this.GoodConditionStepLad.Name = "GoodConditionStepLad";
            this.GoodConditionStepLad.Size = new System.Drawing.Size(170, 19);
            this.GoodConditionStepLad.TabIndex = 1;
            this.GoodConditionStepLad.TabStop = true;
            this.GoodConditionStepLad.Text = "Ladder is in good condition";
            this.GoodConditionStepLad.UseVisualStyleBackColor = true;
            // 
            // RemoveLadderStepPod
            // 
            this.RemoveLadderStepPod.AutoSize = true;
            this.RemoveLadderStepPod.Location = new System.Drawing.Point(7, 23);
            this.RemoveLadderStepPod.Name = "RemoveLadderStepPod";
            this.RemoveLadderStepPod.Size = new System.Drawing.Size(291, 19);
            this.RemoveLadderStepPod.TabIndex = 0;
            this.RemoveLadderStepPod.TabStop = true;
            this.RemoveLadderStepPod.Text = "Ladder tagged as damaged and removed from use";
            this.RemoveLadderStepPod.UseVisualStyleBackColor = true;
            // 
            // LadderConditionSetpPod
            // 
            this.LadderConditionSetpPod.Controls.Add(this.OtherConditionStepPod);
            this.LadderConditionSetpPod.Controls.Add(this.StepsConditionStepPod);
            this.LadderConditionSetpPod.Controls.Add(this.GeneralConditionStepPod);
            this.LadderConditionSetpPod.Controls.Add(this.RailsConditionStepPod);
            this.LadderConditionSetpPod.Controls.Add(this.SpreaderConditionStepPod);
            this.LadderConditionSetpPod.Controls.Add(this.LabelsConditionStepPod);
            this.LadderConditionSetpPod.Controls.Add(this.TopConditionStepPod);
            this.LadderConditionSetpPod.Controls.Add(this.PlatformConditionStepPod);
            this.LadderConditionSetpPod.Location = new System.Drawing.Point(19, 22);
            this.LadderConditionSetpPod.Name = "LadderConditionSetpPod";
            this.LadderConditionSetpPod.Size = new System.Drawing.Size(303, 228);
            this.LadderConditionSetpPod.TabIndex = 8;
            this.LadderConditionSetpPod.TabStop = false;
            this.LadderConditionSetpPod.Text = "Ladder Condition";
            // 
            // OtherConditionStepPod
            // 
            this.OtherConditionStepPod.AutoSize = true;
            this.OtherConditionStepPod.Location = new System.Drawing.Point(6, 202);
            this.OtherConditionStepPod.Name = "OtherConditionStepPod";
            this.OtherConditionStepPod.Size = new System.Drawing.Size(186, 19);
            this.OtherConditionStepPod.TabIndex = 7;
            this.OtherConditionStepPod.Text = "Other: Bracing, shoes, or rivets";
            this.OtherConditionStepPod.UseVisualStyleBackColor = true;
            // 
            // StepsConditionStepPod
            // 
            this.StepsConditionStepPod.AutoSize = true;
            this.StepsConditionStepPod.Location = new System.Drawing.Point(6, 22);
            this.StepsConditionStepPod.Name = "StepsConditionStepPod";
            this.StepsConditionStepPod.Size = new System.Drawing.Size(235, 19);
            this.StepsConditionStepPod.TabIndex = 0;
            this.StepsConditionStepPod.Text = "Steps: Loose, cracked, bent, or missing  ";
            this.StepsConditionStepPod.UseVisualStyleBackColor = true;
            // 
            // GeneralConditionStepPod
            // 
            this.GeneralConditionStepPod.AutoSize = true;
            this.GeneralConditionStepPod.Location = new System.Drawing.Point(5, 177);
            this.GeneralConditionStepPod.Name = "GeneralConditionStepPod";
            this.GeneralConditionStepPod.Size = new System.Drawing.Size(202, 19);
            this.GeneralConditionStepPod.TabIndex = 6;
            this.GeneralConditionStepPod.Text = "General: Rust, corrosion, or loose ";
            this.GeneralConditionStepPod.UseVisualStyleBackColor = true;
            // 
            // RailsConditionStepPod
            // 
            this.RailsConditionStepPod.AutoSize = true;
            this.RailsConditionStepPod.Location = new System.Drawing.Point(6, 48);
            this.RailsConditionStepPod.Name = "RailsConditionStepPod";
            this.RailsConditionStepPod.Size = new System.Drawing.Size(276, 19);
            this.RailsConditionStepPod.TabIndex = 1;
            this.RailsConditionStepPod.Text = "Rails: Cracked, bent, split or frayed rails shields  ";
            this.RailsConditionStepPod.UseVisualStyleBackColor = true;
            // 
            // SpreaderConditionStepPod
            // 
            this.SpreaderConditionStepPod.AutoSize = true;
            this.SpreaderConditionStepPod.Location = new System.Drawing.Point(5, 151);
            this.SpreaderConditionStepPod.Name = "SpreaderConditionStepPod";
            this.SpreaderConditionStepPod.Size = new System.Drawing.Size(205, 19);
            this.SpreaderConditionStepPod.TabIndex = 5;
            this.SpreaderConditionStepPod.Text = "Spreader: Loose, bent, or broken   ";
            this.SpreaderConditionStepPod.UseVisualStyleBackColor = true;
            // 
            // LabelsConditionStepPod
            // 
            this.LabelsConditionStepPod.AutoSize = true;
            this.LabelsConditionStepPod.Location = new System.Drawing.Point(6, 74);
            this.LabelsConditionStepPod.Name = "LabelsConditionStepPod";
            this.LabelsConditionStepPod.Size = new System.Drawing.Size(191, 19);
            this.LabelsConditionStepPod.TabIndex = 2;
            this.LabelsConditionStepPod.Text = "Labels: Missing or not legible    ";
            this.LabelsConditionStepPod.UseVisualStyleBackColor = true;
            // 
            // TopConditionStepPod
            // 
            this.TopConditionStepPod.AutoSize = true;
            this.TopConditionStepPod.Location = new System.Drawing.Point(6, 126);
            this.TopConditionStepPod.Name = "TopConditionStepPod";
            this.TopConditionStepPod.Size = new System.Drawing.Size(201, 19);
            this.TopConditionStepPod.TabIndex = 4;
            this.TopConditionStepPod.Text = "Top: Cracked, loose, or missing    ";
            this.TopConditionStepPod.UseVisualStyleBackColor = true;
            // 
            // PlatformConditionStepPod
            // 
            this.PlatformConditionStepPod.AutoSize = true;
            this.PlatformConditionStepPod.Location = new System.Drawing.Point(6, 100);
            this.PlatformConditionStepPod.Name = "PlatformConditionStepPod";
            this.PlatformConditionStepPod.Size = new System.Drawing.Size(168, 19);
            this.PlatformConditionStepPod.TabIndex = 3;
            this.PlatformConditionStepPod.Text = "Platform: Cracked or bent. ";
            this.PlatformConditionStepPod.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(317, 11);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 369);
            this.vScrollBar1.TabIndex = 11;
            // 
            // StepAndPodiumLadder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LadderInspectionStepPod);
            this.Name = "StepAndPodiumLadder";
            this.Text = "Safety Inspection Form";
            this.LadderInspectionStepPod.ResumeLayout(false);
            this.ActionStepPod.ResumeLayout(false);
            this.ActionStepPod.PerformLayout();
            this.LadderConditionSetpPod.ResumeLayout(false);
            this.LadderConditionSetpPod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LadderInspectionStepPod;
        private System.Windows.Forms.Button NextButtonStepPod;
        private System.Windows.Forms.GroupBox ActionStepPod;
        private System.Windows.Forms.RadioButton GoodConditionStepLad;
        private System.Windows.Forms.RadioButton RemoveLadderStepPod;
        private System.Windows.Forms.GroupBox LadderConditionSetpPod;
        private System.Windows.Forms.CheckBox OtherConditionStepPod;
        private System.Windows.Forms.CheckBox StepsConditionStepPod;
        private System.Windows.Forms.CheckBox GeneralConditionStepPod;
        private System.Windows.Forms.CheckBox RailsConditionStepPod;
        private System.Windows.Forms.CheckBox SpreaderConditionStepPod;
        private System.Windows.Forms.CheckBox LabelsConditionStepPod;
        private System.Windows.Forms.CheckBox TopConditionStepPod;
        private System.Windows.Forms.CheckBox PlatformConditionStepPod;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}