namespace SafetyInspectionApp
{
    partial class LadderFormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadderFormMain));
            this.LadderInfoGroup = new System.Windows.Forms.GroupBox();
            this.ladderNumTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LadderTypeGroup = new System.Windows.Forms.GroupBox();
            this.ExtensionRadioButton = new System.Windows.Forms.RadioButton();
            this.PodiumRadioButton = new System.Windows.Forms.RadioButton();
            this.SetpLadderRadioButton = new System.Windows.Forms.RadioButton();
            this.LadderMaterialGroup = new System.Windows.Forms.GroupBox();
            this.AluminumRadioButton = new System.Windows.Forms.RadioButton();
            this.FiberglassRadioButton = new System.Windows.Forms.RadioButton();
            this.NextLadderFormButton = new System.Windows.Forms.Button();
            this.LadInspectGroup = new System.Windows.Forms.Panel();
            this.LadderInfoGroup.SuspendLayout();
            this.LadderTypeGroup.SuspendLayout();
            this.LadderMaterialGroup.SuspendLayout();
            this.LadInspectGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // LadderInfoGroup
            // 
            this.LadderInfoGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LadderInfoGroup.Controls.Add(this.ladderNumTextBox);
            this.LadderInfoGroup.Controls.Add(this.locationTextBox);
            this.LadderInfoGroup.Controls.Add(this.label2);
            this.LadderInfoGroup.Controls.Add(this.label1);
            this.LadderInfoGroup.Location = new System.Drawing.Point(16, 13);
            this.LadderInfoGroup.Name = "LadderInfoGroup";
            this.LadderInfoGroup.Size = new System.Drawing.Size(383, 100);
            this.LadderInfoGroup.TabIndex = 2;
            this.LadderInfoGroup.TabStop = false;
            this.LadderInfoGroup.Text = "Basic Ladder Info";
            // 
            // ladderNumTextBox
            // 
            this.ladderNumTextBox.Location = new System.Drawing.Point(105, 27);
            this.ladderNumTextBox.Name = "ladderNumTextBox";
            this.ladderNumTextBox.PlaceholderText = "Ladder#";
            this.ladderNumTextBox.Size = new System.Drawing.Size(52, 23);
            this.ladderNumTextBox.TabIndex = 0;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(68, 55);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.PlaceholderText = "Location";
            this.locationTextBox.Size = new System.Drawing.Size(89, 23);
            this.locationTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ladder Number:";
            // 
            // LadderTypeGroup
            // 
            this.LadderTypeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LadderTypeGroup.Controls.Add(this.ExtensionRadioButton);
            this.LadderTypeGroup.Controls.Add(this.PodiumRadioButton);
            this.LadderTypeGroup.Controls.Add(this.SetpLadderRadioButton);
            this.LadderTypeGroup.Location = new System.Drawing.Point(16, 117);
            this.LadderTypeGroup.Name = "LadderTypeGroup";
            this.LadderTypeGroup.Size = new System.Drawing.Size(383, 114);
            this.LadderTypeGroup.TabIndex = 3;
            this.LadderTypeGroup.TabStop = false;
            this.LadderTypeGroup.Text = "Ladder Type";
            // 
            // ExtensionRadioButton
            // 
            this.ExtensionRadioButton.AutoSize = true;
            this.ExtensionRadioButton.Location = new System.Drawing.Point(7, 73);
            this.ExtensionRadioButton.Name = "ExtensionRadioButton";
            this.ExtensionRadioButton.Size = new System.Drawing.Size(76, 19);
            this.ExtensionRadioButton.TabIndex = 0;
            this.ExtensionRadioButton.TabStop = true;
            this.ExtensionRadioButton.Text = "Extension";
            this.ExtensionRadioButton.UseVisualStyleBackColor = true;
            // 
            // PodiumRadioButton
            // 
            this.PodiumRadioButton.AutoSize = true;
            this.PodiumRadioButton.Location = new System.Drawing.Point(7, 48);
            this.PodiumRadioButton.Name = "PodiumRadioButton";
            this.PodiumRadioButton.Size = new System.Drawing.Size(67, 19);
            this.PodiumRadioButton.TabIndex = 0;
            this.PodiumRadioButton.TabStop = true;
            this.PodiumRadioButton.Text = "Podium";
            this.PodiumRadioButton.UseVisualStyleBackColor = true;
            // 
            // SetpLadderRadioButton
            // 
            this.SetpLadderRadioButton.AutoSize = true;
            this.SetpLadderRadioButton.Location = new System.Drawing.Point(7, 23);
            this.SetpLadderRadioButton.Name = "SetpLadderRadioButton";
            this.SetpLadderRadioButton.Size = new System.Drawing.Size(87, 19);
            this.SetpLadderRadioButton.TabIndex = 0;
            this.SetpLadderRadioButton.TabStop = true;
            this.SetpLadderRadioButton.Text = "Step Ladder";
            this.SetpLadderRadioButton.UseVisualStyleBackColor = true;
            // 
            // LadderMaterialGroup
            // 
            this.LadderMaterialGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LadderMaterialGroup.Controls.Add(this.AluminumRadioButton);
            this.LadderMaterialGroup.Controls.Add(this.FiberglassRadioButton);
            this.LadderMaterialGroup.Location = new System.Drawing.Point(16, 229);
            this.LadderMaterialGroup.Name = "LadderMaterialGroup";
            this.LadderMaterialGroup.Size = new System.Drawing.Size(383, 89);
            this.LadderMaterialGroup.TabIndex = 3;
            this.LadderMaterialGroup.TabStop = false;
            this.LadderMaterialGroup.Text = "Ladder Material";
            // 
            // AluminumRadioButton
            // 
            this.AluminumRadioButton.AutoSize = true;
            this.AluminumRadioButton.Location = new System.Drawing.Point(7, 48);
            this.AluminumRadioButton.Name = "AluminumRadioButton";
            this.AluminumRadioButton.Size = new System.Drawing.Size(82, 19);
            this.AluminumRadioButton.TabIndex = 0;
            this.AluminumRadioButton.TabStop = true;
            this.AluminumRadioButton.Text = "Aluminum";
            this.AluminumRadioButton.UseVisualStyleBackColor = true;
            // 
            // FiberglassRadioButton
            // 
            this.FiberglassRadioButton.AutoSize = true;
            this.FiberglassRadioButton.Location = new System.Drawing.Point(7, 23);
            this.FiberglassRadioButton.Name = "FiberglassRadioButton";
            this.FiberglassRadioButton.Size = new System.Drawing.Size(77, 19);
            this.FiberglassRadioButton.TabIndex = 0;
            this.FiberglassRadioButton.TabStop = true;
            this.FiberglassRadioButton.Text = "Fiberglass";
            this.FiberglassRadioButton.UseVisualStyleBackColor = true;
            // 
            // NextLadderFormButton
            // 
            this.NextLadderFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextLadderFormButton.Location = new System.Drawing.Point(19, 324);
            this.NextLadderFormButton.Name = "NextLadderFormButton";
            this.NextLadderFormButton.Size = new System.Drawing.Size(377, 25);
            this.NextLadderFormButton.TabIndex = 4;
            this.NextLadderFormButton.Text = "Next";
            this.NextLadderFormButton.UseVisualStyleBackColor = true;
            this.NextLadderFormButton.Click += new System.EventHandler(this.NextLadderFormButton_Click);
            // 
            // LadInspectGroup
            // 
            this.LadInspectGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LadInspectGroup.Controls.Add(this.LadderInfoGroup);
            this.LadInspectGroup.Controls.Add(this.NextLadderFormButton);
            this.LadInspectGroup.Controls.Add(this.LadderTypeGroup);
            this.LadInspectGroup.Controls.Add(this.LadderMaterialGroup);
            this.LadInspectGroup.Location = new System.Drawing.Point(127, 12);
            this.LadInspectGroup.Name = "LadInspectGroup";
            this.LadInspectGroup.Size = new System.Drawing.Size(433, 410);
            this.LadInspectGroup.TabIndex = 1;
            // 
            // LadderFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 476);
            this.Controls.Add(this.LadInspectGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LadderFormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Safety Inspection Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LadderFormMain_FormClosing);
            this.LadderInfoGroup.ResumeLayout(false);
            this.LadderInfoGroup.PerformLayout();
            this.LadderTypeGroup.ResumeLayout(false);
            this.LadderTypeGroup.PerformLayout();
            this.LadderMaterialGroup.ResumeLayout(false);
            this.LadderMaterialGroup.PerformLayout();
            this.LadInspectGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LadderInfoGroup;
        private System.Windows.Forms.TextBox ladderNumTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox LadderTypeGroup;
        private System.Windows.Forms.RadioButton ExtensionRadioButton;
        private System.Windows.Forms.RadioButton PodiumRadioButton;
        private System.Windows.Forms.RadioButton SetpLadderRadioButton;
        private System.Windows.Forms.GroupBox LadderMaterialGroup;
        private System.Windows.Forms.RadioButton AluminumRadioButton;
        private System.Windows.Forms.RadioButton FiberglassRadioButton;
        private System.Windows.Forms.Button NextLadderFormButton;
        private System.Windows.Forms.Panel LadInspectGroup;
    }
}

