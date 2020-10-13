namespace SafetyInspectionApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.LadderInspectionGroupBox = new System.Windows.Forms.GroupBox();
            this.exmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.ladderMaterialGroupBox = new System.Windows.Forms.GroupBox();
            this.aluminumButton = new System.Windows.Forms.RadioButton();
            this.figerglassButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.ladderNumberTextBox = new System.Windows.Forms.TextBox();
            this.ladderNumberLabel = new System.Windows.Forms.Label();
            this.ladderTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.extensionLadderButton = new System.Windows.Forms.RadioButton();
            this.podiumButton = new System.Windows.Forms.RadioButton();
            this.stepLadderButton = new System.Windows.Forms.RadioButton();
            this.NextFormButton = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.LadderInspectionGroupBox.SuspendLayout();
            this.ladderMaterialGroupBox.SuspendLayout();
            this.ladderTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 5;
            // 
            // LadderInspectionGroupBox
            // 
            this.LadderInspectionGroupBox.Controls.Add(this.locationLabel);
            this.LadderInspectionGroupBox.Controls.Add(this.NextFormButton);
            this.LadderInspectionGroupBox.Controls.Add(this.ladderTypeGroupBox);
            this.LadderInspectionGroupBox.Controls.Add(this.exmployeeNameTextBox);
            this.LadderInspectionGroupBox.Controls.Add(this.employeeNameLabel);
            this.LadderInspectionGroupBox.Controls.Add(this.ladderMaterialGroupBox);
            this.LadderInspectionGroupBox.Controls.Add(this.label3);
            this.LadderInspectionGroupBox.Controls.Add(this.locationTextBox);
            this.LadderInspectionGroupBox.Controls.Add(this.ladderNumberTextBox);
            this.LadderInspectionGroupBox.Controls.Add(this.ladderNumberLabel);
            this.LadderInspectionGroupBox.Location = new System.Drawing.Point(35, 30);
            this.LadderInspectionGroupBox.Name = "LadderInspectionGroupBox";
            this.LadderInspectionGroupBox.Size = new System.Drawing.Size(1090, 806);
            this.LadderInspectionGroupBox.TabIndex = 6;
            this.LadderInspectionGroupBox.TabStop = false;
            this.LadderInspectionGroupBox.Text = "Ladder Inspection";
            // 
            // exmployeeNameTextBox
            // 
            this.exmployeeNameTextBox.Location = new System.Drawing.Point(221, 97);
            this.exmployeeNameTextBox.Name = "exmployeeNameTextBox";
            this.exmployeeNameTextBox.Size = new System.Drawing.Size(228, 31);
            this.exmployeeNameTextBox.TabIndex = 10;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(29, 100);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(186, 25);
            this.employeeNameLabel.TabIndex = 9;
            this.employeeNameLabel.Text = "Exmployee Name:";
            // 
            // ladderMaterialGroupBox
            // 
            this.ladderMaterialGroupBox.Controls.Add(this.aluminumButton);
            this.ladderMaterialGroupBox.Controls.Add(this.figerglassButton);
            this.ladderMaterialGroupBox.Location = new System.Drawing.Point(25, 532);
            this.ladderMaterialGroupBox.Name = "ladderMaterialGroupBox";
            this.ladderMaterialGroupBox.Size = new System.Drawing.Size(242, 156);
            this.ladderMaterialGroupBox.TabIndex = 6;
            this.ladderMaterialGroupBox.TabStop = false;
            this.ladderMaterialGroupBox.Text = "Ladder Material";
            // 
            // aluminumButton
            // 
            this.aluminumButton.AutoSize = true;
            this.aluminumButton.Location = new System.Drawing.Point(17, 90);
            this.aluminumButton.Name = "aluminumButton";
            this.aluminumButton.Size = new System.Drawing.Size(137, 29);
            this.aluminumButton.TabIndex = 1;
            this.aluminumButton.TabStop = true;
            this.aluminumButton.Text = "Aluminum";
            this.aluminumButton.UseVisualStyleBackColor = true;
            // 
            // figerglassButton
            // 
            this.figerglassButton.AutoSize = true;
            this.figerglassButton.Location = new System.Drawing.Point(17, 40);
            this.figerglassButton.Name = "figerglassButton";
            this.figerglassButton.Size = new System.Drawing.Size(143, 29);
            this.figerglassButton.TabIndex = 0;
            this.figerglassButton.TabStop = true;
            this.figerglassButton.Text = "Fiberglass";
            this.figerglassButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 4;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(132, 209);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(158, 31);
            this.locationTextBox.TabIndex = 3;
            // 
            // ladderNumberTextBox
            // 
            this.ladderNumberTextBox.Location = new System.Drawing.Point(132, 161);
            this.ladderNumberTextBox.Name = "ladderNumberTextBox";
            this.ladderNumberTextBox.Size = new System.Drawing.Size(158, 31);
            this.ladderNumberTextBox.TabIndex = 1;
            // 
            // ladderNumberLabel
            // 
            this.ladderNumberLabel.AutoSize = true;
            this.ladderNumberLabel.Location = new System.Drawing.Point(29, 161);
            this.ladderNumberLabel.Name = "ladderNumberLabel";
            this.ladderNumberLabel.Size = new System.Drawing.Size(103, 25);
            this.ladderNumberLabel.TabIndex = 0;
            this.ladderNumberLabel.Text = "Ladder #:";
            // 
            // ladderTypeGroupBox
            // 
            this.ladderTypeGroupBox.Controls.Add(this.extensionLadderButton);
            this.ladderTypeGroupBox.Controls.Add(this.podiumButton);
            this.ladderTypeGroupBox.Controls.Add(this.stepLadderButton);
            this.ladderTypeGroupBox.Location = new System.Drawing.Point(25, 298);
            this.ladderTypeGroupBox.Name = "ladderTypeGroupBox";
            this.ladderTypeGroupBox.Size = new System.Drawing.Size(458, 194);
            this.ladderTypeGroupBox.TabIndex = 12;
            this.ladderTypeGroupBox.TabStop = false;
            this.ladderTypeGroupBox.Text = "Ladder Type";
            // 
            // extensionLadderButton
            // 
            this.extensionLadderButton.AutoSize = true;
            this.extensionLadderButton.Location = new System.Drawing.Point(17, 137);
            this.extensionLadderButton.Name = "extensionLadderButton";
            this.extensionLadderButton.Size = new System.Drawing.Size(138, 29);
            this.extensionLadderButton.TabIndex = 2;
            this.extensionLadderButton.TabStop = true;
            this.extensionLadderButton.Text = "Extension";
            this.extensionLadderButton.UseVisualStyleBackColor = true;
            // 
            // podiumButton
            // 
            this.podiumButton.AutoSize = true;
            this.podiumButton.Location = new System.Drawing.Point(17, 94);
            this.podiumButton.Name = "podiumButton";
            this.podiumButton.Size = new System.Drawing.Size(115, 29);
            this.podiumButton.TabIndex = 1;
            this.podiumButton.TabStop = true;
            this.podiumButton.Text = "Podium";
            this.podiumButton.UseVisualStyleBackColor = true;
            // 
            // stepLadderButton
            // 
            this.stepLadderButton.AutoSize = true;
            this.stepLadderButton.Location = new System.Drawing.Point(17, 48);
            this.stepLadderButton.Name = "stepLadderButton";
            this.stepLadderButton.Size = new System.Drawing.Size(160, 29);
            this.stepLadderButton.TabIndex = 0;
            this.stepLadderButton.TabStop = true;
            this.stepLadderButton.Text = "Step Ladder";
            this.stepLadderButton.UseVisualStyleBackColor = true;
            // 
            // NextFormButton
            // 
            this.NextFormButton.Location = new System.Drawing.Point(645, 644);
            this.NextFormButton.Name = "NextFormButton";
            this.NextFormButton.Size = new System.Drawing.Size(108, 59);
            this.NextFormButton.TabIndex = 13;
            this.NextFormButton.Text = "Next";
            this.NextFormButton.UseVisualStyleBackColor = true;
            this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(29, 212);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(100, 25);
            this.locationLabel.TabIndex = 14;
            this.locationLabel.Text = "Location:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 865);
            this.Controls.Add(this.LadderInspectionGroupBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Safety Inspection Form";
            this.LadderInspectionGroupBox.ResumeLayout(false);
            this.LadderInspectionGroupBox.PerformLayout();
            this.ladderMaterialGroupBox.ResumeLayout(false);
            this.ladderMaterialGroupBox.PerformLayout();
            this.ladderTypeGroupBox.ResumeLayout(false);
            this.ladderTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox LadderInspectionGroupBox;
        private System.Windows.Forms.TextBox exmployeeNameTextBox;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.GroupBox ladderMaterialGroupBox;
        private System.Windows.Forms.RadioButton aluminumButton;
        private System.Windows.Forms.RadioButton figerglassButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox ladderNumberTextBox;
        private System.Windows.Forms.Label ladderNumberLabel;
        private System.Windows.Forms.Button NextFormButton;
        private System.Windows.Forms.GroupBox ladderTypeGroupBox;
        private System.Windows.Forms.RadioButton extensionLadderButton;
        private System.Windows.Forms.RadioButton podiumButton;
        private System.Windows.Forms.RadioButton stepLadderButton;
        private System.Windows.Forms.Label locationLabel;
    }
}

