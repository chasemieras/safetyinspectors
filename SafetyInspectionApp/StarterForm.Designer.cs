namespace SafetyInspectionApp
{
    partial class StarterForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainNextButton = new System.Windows.Forms.Button();
            this.FormSelectGroup = new System.Windows.Forms.GroupBox();
            this.LadderForm = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FormSelectGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Safety Inspection Form. Please input your name, \r\nselect the for y" +
    "ou want to do, and press the next button.\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name:";
            // 
            // MainNextButton
            // 
            this.MainNextButton.Location = new System.Drawing.Point(63, 71);
            this.MainNextButton.Name = "MainNextButton";
            this.MainNextButton.Size = new System.Drawing.Size(75, 23);
            this.MainNextButton.TabIndex = 3;
            this.MainNextButton.Text = "Next";
            this.MainNextButton.UseVisualStyleBackColor = true;
            this.MainNextButton.Click += new System.EventHandler(this.MainNextButton_Click);
            // 
            // FormSelectGroup
            // 
            this.FormSelectGroup.Controls.Add(this.LadderForm);
            this.FormSelectGroup.Controls.Add(this.MainNextButton);
            this.FormSelectGroup.Location = new System.Drawing.Point(306, 213);
            this.FormSelectGroup.Name = "FormSelectGroup";
            this.FormSelectGroup.Size = new System.Drawing.Size(200, 100);
            this.FormSelectGroup.TabIndex = 4;
            this.FormSelectGroup.TabStop = false;
            this.FormSelectGroup.Text = "Form Selection";
            // 
            // LadderForm
            // 
            this.LadderForm.AutoSize = true;
            this.LadderForm.Location = new System.Drawing.Point(6, 22);
            this.LadderForm.Name = "LadderForm";
            this.LadderForm.Size = new System.Drawing.Size(120, 19);
            this.LadderForm.TabIndex = 4;
            this.LadderForm.Text = "Ladder Inspection";
            this.LadderForm.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // StarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FormSelectGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "StarterForm";
            this.Text = "Safety Inspection Form";
            this.FormSelectGroup.ResumeLayout(false);
            this.FormSelectGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MainNextButton;
        private System.Windows.Forms.GroupBox FormSelectGroup;
        private System.Windows.Forms.CheckBox LadderForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}