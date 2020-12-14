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
            this.IntroLabel = new System.Windows.Forms.Label();
            this.FormSelectGroup = new System.Windows.Forms.GroupBox();
            this.formButton = new System.Windows.Forms.Button();
            this.FormSelectionText = new System.Windows.Forms.Label();
            this.formSelectionDropDown = new System.Windows.Forms.ComboBox();
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
            // IntroLabel
            // 
            this.IntroLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IntroLabel.AutoSize = true;
            this.IntroLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IntroLabel.Location = new System.Drawing.Point(95, 9);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(603, 45);
            this.IntroLabel.TabIndex = 1;
            this.IntroLabel.Text = resources.GetString("IntroLabel.Text");
            this.IntroLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormSelectGroup
            // 
            this.FormSelectGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FormSelectGroup.BackColor = System.Drawing.Color.White;
            this.FormSelectGroup.Controls.Add(this.formButton);
            this.FormSelectGroup.Controls.Add(this.FormSelectionText);
            this.FormSelectGroup.Controls.Add(this.formSelectionDropDown);
            this.FormSelectGroup.Controls.Add(this.startCamera);
            this.FormSelectGroup.Controls.Add(this.cameraDisplay);
            this.FormSelectGroup.Controls.Add(this.label3);
            this.FormSelectGroup.Controls.Add(this.systemCameraList);
            this.FormSelectGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormSelectGroup.Location = new System.Drawing.Point(206, 57);
            this.FormSelectGroup.Name = "FormSelectGroup";
            this.FormSelectGroup.Size = new System.Drawing.Size(401, 433);
            this.FormSelectGroup.TabIndex = 4;
            this.FormSelectGroup.TabStop = false;
            this.FormSelectGroup.Text = "Scan a QR Code";
            // 
            // formButton
            // 
            this.formButton.BackColor = System.Drawing.Color.White;
            this.formButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.formButton.Location = new System.Drawing.Point(286, 397);
            this.formButton.Name = "formButton";
            this.formButton.Size = new System.Drawing.Size(58, 23);
            this.formButton.TabIndex = 8;
            this.formButton.Text = "Go To";
            this.formButton.UseVisualStyleBackColor = false;
            this.formButton.Click += new System.EventHandler(this.goToForm_Click);
            // 
            // FormSelectionText
            // 
            this.FormSelectionText.AutoSize = true;
            this.FormSelectionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormSelectionText.Location = new System.Drawing.Point(8, 397);
            this.FormSelectionText.Name = "FormSelectionText";
            this.FormSelectionText.Size = new System.Drawing.Size(55, 30);
            this.FormSelectionText.TabIndex = 6;
            this.FormSelectionText.Text = "Form\r\nSelection";
            this.FormSelectionText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formSelectionDropDown
            // 
            this.formSelectionDropDown.FormattingEnabled = true;
            this.formSelectionDropDown.Location = new System.Drawing.Point(69, 397);
            this.formSelectionDropDown.Name = "formSelectionDropDown";
            this.formSelectionDropDown.Size = new System.Drawing.Size(211, 23);
            this.formSelectionDropDown.TabIndex = 9;
            // 
            // startCamera
            // 
            this.startCamera.BackColor = System.Drawing.Color.White;
            this.startCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.startCamera.Location = new System.Drawing.Point(279, 21);
            this.startCamera.Name = "startCamera";
            this.startCamera.Size = new System.Drawing.Size(58, 23);
            this.startCamera.TabIndex = 8;
            this.startCamera.Text = "Start";
            this.startCamera.UseVisualStyleBackColor = false;
            this.startCamera.Click += new System.EventHandler(this.startCamera_Click);
            // 
            // cameraDisplay
            // 
            this.cameraDisplay.Location = new System.Drawing.Point(33, 65);
            this.cameraDisplay.Name = "cameraDisplay";
            this.cameraDisplay.Size = new System.Drawing.Size(343, 252);
            this.cameraDisplay.TabIndex = 7;
            this.cameraDisplay.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Camera\r\nSelection";
            // 
            // systemCameraList
            // 
            this.systemCameraList.BackColor = System.Drawing.Color.White;
            this.systemCameraList.FormattingEnabled = true;
            this.systemCameraList.Location = new System.Drawing.Point(67, 21);
            this.systemCameraList.Name = "systemCameraList";
            this.systemCameraList.Size = new System.Drawing.Size(209, 23);
            this.systemCameraList.TabIndex = 5;
            // 
            // cameraTicker
            // 
            this.cameraTicker.Interval = 60;
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.FormSelectGroup);
            this.Controls.Add(this.IntroLabel);
            this.ForeColor = System.Drawing.Color.Coral;
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
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.GroupBox FormSelectGroup;

        //Camera Code
        private System.Windows.Forms.PictureBox cameraDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox systemCameraList;
        private System.Windows.Forms.Button startCamera;
        private System.Windows.Forms.Timer cameraTicker;
        private System.Windows.Forms.ErrorProvider validator;
        private System.Windows.Forms.Button formButton;
        private System.Windows.Forms.Label FormSelectionText;
        private System.Windows.Forms.ComboBox formSelectionDropDown;
    }
}