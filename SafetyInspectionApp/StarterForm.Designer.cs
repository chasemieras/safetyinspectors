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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarterForm));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.FormSelectGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.formSelectionList = new System.Windows.Forms.ComboBox();
            this.startCamera = new System.Windows.Forms.Button();
            this.cameraDisplay = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.systemCameraList = new System.Windows.Forms.ComboBox();
            this.cameraTicker = new System.Windows.Forms.Timer(this.components);
            this.validator = new System.Windows.Forms.ErrorProvider(this.components);
            this.FormSelectGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameTextBox.Location = new System.Drawing.Point(348, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(149, 23);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // IntroLabel
            // 
            this.IntroLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IntroLabel.AutoSize = true;
            this.IntroLabel.Location = new System.Drawing.Point(228, 9);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(351, 45);
            this.IntroLabel.TabIndex = 1;
            this.IntroLabel.Text = "Welcome to the Safety Inspection Form. Please input your name, \r\nand scan the QR " +
    "code for the form.\r\n\r\n";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(245, 60);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(97, 15);
            this.employeeNameLabel.TabIndex = 2;
            this.employeeNameLabel.Text = "Employee Name:";
            // 
            // FormSelectGroup
            // 
            this.FormSelectGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormSelectGroup.Controls.Add(this.label1);
            this.FormSelectGroup.Controls.Add(this.formSelectionList);
            this.FormSelectGroup.Controls.Add(this.startCamera);
            this.FormSelectGroup.Controls.Add(this.cameraDisplay);
            this.FormSelectGroup.Controls.Add(this.label3);
            this.FormSelectGroup.Controls.Add(this.systemCameraList);
            this.FormSelectGroup.Location = new System.Drawing.Point(228, 86);
            this.FormSelectGroup.Name = "FormSelectGroup";
            this.FormSelectGroup.Size = new System.Drawing.Size(343, 331);
            this.FormSelectGroup.TabIndex = 4;
            this.FormSelectGroup.TabStop = false;
            this.FormSelectGroup.Text = "Scan a QR Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "-or- Select a Form";
            // 
            // formSelectionList
            // 
            this.formSelectionList.FormattingEnabled = true;
            this.formSelectionList.Location = new System.Drawing.Point(116, 50);
            this.formSelectionList.Name = "formSelectionList";
            this.formSelectionList.Size = new System.Drawing.Size(217, 23);
            this.formSelectionList.TabIndex = 9;
            this.formSelectionList.SelectedIndexChanged += new System.EventHandler(this.formSelection_SelectedIndexChanged);
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
            this.cameraDisplay.Location = new System.Drawing.Point(0, 79);
            this.cameraDisplay.Name = "cameraDisplay";
            this.cameraDisplay.Size = new System.Drawing.Size(343, 252);
            this.cameraDisplay.TabIndex = 7;
            this.cameraDisplay.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Camera\r\nSelection";
            // 
            // systemCameraList
            // 
            this.systemCameraList.FormattingEnabled = true;
            this.systemCameraList.Location = new System.Drawing.Point(67, 21);
            this.systemCameraList.Name = "systemCameraList";
            this.systemCameraList.Size = new System.Drawing.Size(209, 23);
            this.systemCameraList.TabIndex = 5;
            // 
            // cameraTicker
            // 
            this.cameraTicker.Interval = 1000;
            this.cameraTicker.Tick += new System.EventHandler(this.cameraTicker_Tick);
            // 
            // validator
            // 
            this.validator.ContainerControl = this;
            // 
            // StarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormSelectGroup);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.IntroLabel);
            this.Controls.Add(this.nameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StarterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Safety Inspection Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StarterForm_FormClosing);
            this.Load += new System.EventHandler(this.StarterForm_Load);
            this.FormSelectGroup.ResumeLayout(false);
            this.FormSelectGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.GroupBox FormSelectGroup;

        //Camera Code
        private System.Windows.Forms.PictureBox cameraDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox systemCameraList;
        private System.Windows.Forms.Button startCamera;
        private System.Windows.Forms.Timer cameraTicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox formSelectionList;
        private System.Windows.Forms.ErrorProvider validator;
    }
}