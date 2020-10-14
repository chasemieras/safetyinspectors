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
            this.LadderInspectGroup = new System.Windows.Forms.GroupBox();
            this.NextLadderFormButton = new System.Windows.Forms.Button();
            this.LadderMaterial = new System.Windows.Forms.GroupBox();
            this.AluminumRadioButton = new System.Windows.Forms.RadioButton();
            this.FiberglassRadioButton = new System.Windows.Forms.RadioButton();
            this.LadderType = new System.Windows.Forms.GroupBox();
            this.ExtensionRadioButton = new System.Windows.Forms.RadioButton();
            this.PodiumRadioButton = new System.Windows.Forms.RadioButton();
            this.SetpLadderRadioButton = new System.Windows.Forms.RadioButton();
            this.LadderInfo = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LadderInspectGroup.SuspendLayout();
            this.LadderMaterial.SuspendLayout();
            this.LadderType.SuspendLayout();
            this.LadderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LadderInspectGroup
            // 
            this.LadderInspectGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LadderInspectGroup.Controls.Add(this.NextLadderFormButton);
            this.LadderInspectGroup.Controls.Add(this.LadderMaterial);
            this.LadderInspectGroup.Controls.Add(this.LadderType);
            this.LadderInspectGroup.Controls.Add(this.LadderInfo);
            this.LadderInspectGroup.Location = new System.Drawing.Point(250, 12);
            this.LadderInspectGroup.MaximumSize = new System.Drawing.Size(440, 900);
            this.LadderInspectGroup.MinimumSize = new System.Drawing.Size(220, 450);
            this.LadderInspectGroup.Name = "LadderInspectGroup";
            this.LadderInspectGroup.Size = new System.Drawing.Size(220, 450);
            this.LadderInspectGroup.TabIndex = 0;
            this.LadderInspectGroup.TabStop = false;
            this.LadderInspectGroup.Text = "Ladder Inspection";
            // 
            // NextLadderFormButton
            // 
            this.NextLadderFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextLadderFormButton.Location = new System.Drawing.Point(33, 329);
            this.NextLadderFormButton.Name = "NextLadderFormButton";
            this.NextLadderFormButton.Size = new System.Drawing.Size(157, 25);
            this.NextLadderFormButton.TabIndex = 4;
            this.NextLadderFormButton.Text = "Next";
            this.NextLadderFormButton.UseVisualStyleBackColor = true;
            this.NextLadderFormButton.Click += new System.EventHandler(this.NextLadderFormButton_Click);
            // 
            // LadderMaterial
            // 
            this.LadderMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LadderMaterial.Controls.Add(this.AluminumRadioButton);
            this.LadderMaterial.Controls.Add(this.FiberglassRadioButton);
            this.LadderMaterial.Location = new System.Drawing.Point(30, 234);
            this.LadderMaterial.Name = "LadderMaterial";
            this.LadderMaterial.Size = new System.Drawing.Size(163, 89);
            this.LadderMaterial.TabIndex = 3;
            this.LadderMaterial.TabStop = false;
            this.LadderMaterial.Text = "Ladder Material";
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
            // LadderType
            // 
            this.LadderType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LadderType.Controls.Add(this.ExtensionRadioButton);
            this.LadderType.Controls.Add(this.PodiumRadioButton);
            this.LadderType.Controls.Add(this.SetpLadderRadioButton);
            this.LadderType.Location = new System.Drawing.Point(30, 126);
            this.LadderType.Name = "LadderType";
            this.LadderType.Size = new System.Drawing.Size(163, 114);
            this.LadderType.TabIndex = 3;
            this.LadderType.TabStop = false;
            this.LadderType.Text = "Ladder Type";
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
            // LadderInfo
            // 
            this.LadderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LadderInfo.Controls.Add(this.textBox2);
            this.LadderInfo.Controls.Add(this.textBox1);
            this.LadderInfo.Controls.Add(this.label2);
            this.LadderInfo.Controls.Add(this.label1);
            this.LadderInfo.Location = new System.Drawing.Point(30, 22);
            this.LadderInfo.Name = "LadderInfo";
            this.LadderInfo.Size = new System.Drawing.Size(163, 100);
            this.LadderInfo.TabIndex = 2;
            this.LadderInfo.TabStop = false;
            this.LadderInfo.Text = "Basic Ladder Info";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Ladder#";
            this.textBox2.Size = new System.Drawing.Size(52, 23);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Location";
            this.textBox1.Size = new System.Drawing.Size(89, 23);
            this.textBox1.TabIndex = 0;
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
            // LadderFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 476);
            this.Controls.Add(this.LadderInspectGroup);
            this.Name = "LadderFormMain";
            this.Text = "Safety Inspection Form";
            this.LadderInspectGroup.ResumeLayout(false);
            this.LadderMaterial.ResumeLayout(false);
            this.LadderMaterial.PerformLayout();
            this.LadderType.ResumeLayout(false);
            this.LadderType.PerformLayout();
            this.LadderInfo.ResumeLayout(false);
            this.LadderInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LadderInspectGroup;
        private System.Windows.Forms.GroupBox LadderInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox LadderType;
        private System.Windows.Forms.GroupBox LadderMaterial;
        private System.Windows.Forms.RadioButton AluminumRadioButton;
        private System.Windows.Forms.RadioButton FiberglassRadioButton;
        private System.Windows.Forms.RadioButton ExtensionRadioButton;
        private System.Windows.Forms.RadioButton PodiumRadioButton;
        private System.Windows.Forms.RadioButton SetpLadderRadioButton;
        private System.Windows.Forms.Button NextLadderFormButton;
    }
}

