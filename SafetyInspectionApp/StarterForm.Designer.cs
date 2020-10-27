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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FormSelectGroup = new System.Windows.Forms.GroupBox();
            this.startCamera = new System.Windows.Forms.Button();
            this.cameraDisplay = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.systemCameraList = new System.Windows.Forms.ComboBox();
            this.cameraTicker = new System.Windows.Forms.Timer(this.components);
            this.FormSelectGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Safety Inspection Form. Please input your name, \r\nand scan the QR " +
    "code for the form.\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Name:";
            // 
            // FormSelectGroup
            // 
            this.FormSelectGroup.Controls.Add(this.startCamera);
            this.FormSelectGroup.Controls.Add(this.cameraDisplay);
            this.FormSelectGroup.Controls.Add(this.label3);
            this.FormSelectGroup.Controls.Add(this.systemCameraList);
            this.FormSelectGroup.Location = new System.Drawing.Point(228, 86);
            this.FormSelectGroup.Name = "FormSelectGroup";
            this.FormSelectGroup.Size = new System.Drawing.Size(343, 331);
            this.FormSelectGroup.TabIndex = 4;
            this.FormSelectGroup.TabStop = false;
            this.FormSelectGroup.Text = "Form Selection";
            // 
            // startCamera
            // 
            this.startCamera.Location = new System.Drawing.Point(279, 21);
            this.startCamera.Name = "startCamera";
            this.startCamera.Size = new System.Drawing.Size(58, 23);
            this.startCamera.TabIndex = 8;
            this.startCamera.Text = "Start";
            this.startCamera.UseVisualStyleBackColor = true;
            this.startCamera.Click += new System.EventHandler(this.startCamera_Click);
            // 
            // cameraDisplay
            // 
            this.cameraDisplay.Location = new System.Drawing.Point(6, 51);
            this.cameraDisplay.Name = "cameraDisplay";
            this.cameraDisplay.Size = new System.Drawing.Size(331, 274);
            this.cameraDisplay.TabIndex = 7;
            this.cameraDisplay.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Camera";
            // 
            // systemCameraList
            // 
            this.systemCameraList.FormattingEnabled = true;
            this.systemCameraList.Location = new System.Drawing.Point(54, 21);
            this.systemCameraList.Name = "systemCameraList";
            this.systemCameraList.Size = new System.Drawing.Size(222, 23);
            this.systemCameraList.TabIndex = 5;
            // 
            // cameraTicker
            // 
            this.cameraTicker.Interval = 1000;
            this.cameraTicker.Tick += new System.EventHandler(this.cameraTicker_Tick);
            // 
            // StarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormSelectGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "StarterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Safety Inspection Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StarterForm_FormClosing);
            this.Load += new System.EventHandler(this.StarterForm_Load);
            this.FormSelectGroup.ResumeLayout(false);
            this.FormSelectGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox FormSelectGroup;

        //Camera Code
        private System.Windows.Forms.PictureBox cameraDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox systemCameraList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startCamera;
        private System.Windows.Forms.Timer cameraTicker;
    }
}