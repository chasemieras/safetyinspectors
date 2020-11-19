namespace SafetyInspectionApp.LadderForms
{
    partial class ConditionForm
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
            this.NextButtonExten = new System.Windows.Forms.Button();
            this.Group = new System.Windows.Forms.Panel();
            this.cameraDisplay = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.systemCameraList = new System.Windows.Forms.ComboBox();
            this.cameraTextBox = new System.Windows.Forms.TextBox();
            this.cameraTicker = new System.Windows.Forms.Timer(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.removeAllImageButton = new System.Windows.Forms.Button();
            this.numImagesText = new System.Windows.Forms.TextBox();
            this.removeLastImageButton = new System.Windows.Forms.Button();
            this.numImages = new System.Windows.Forms.TextBox();
            this.Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // NextButtonExten
            // 
            this.NextButtonExten.Location = new System.Drawing.Point(77, 365);
            this.NextButtonExten.Name = "NextButtonExten";
            this.NextButtonExten.Size = new System.Drawing.Size(212, 23);
            this.NextButtonExten.TabIndex = 3;
            this.NextButtonExten.Text = "Next";
            this.NextButtonExten.UseVisualStyleBackColor = true;
            this.NextButtonExten.Click += new System.EventHandler(this.NextButtonExten_Click);
            // 
            // Group
            // 
            this.Group.Controls.Add(this.NextButtonExten);
            this.Group.Location = new System.Drawing.Point(12, 12);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(376, 423);
            this.Group.TabIndex = 5;
            // 
            // cameraDisplay
            // 
            this.cameraDisplay.Location = new System.Drawing.Point(405, 79);
            this.cameraDisplay.Name = "cameraDisplay";
            this.cameraDisplay.Size = new System.Drawing.Size(267, 256);
            this.cameraDisplay.TabIndex = 6;
            this.cameraDisplay.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(405, 341);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(501, 341);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // systemCameraList
            // 
            this.systemCameraList.FormattingEnabled = true;
            this.systemCameraList.Location = new System.Drawing.Point(463, 36);
            this.systemCameraList.Name = "systemCameraList";
            this.systemCameraList.Size = new System.Drawing.Size(209, 23);
            this.systemCameraList.TabIndex = 9;
            // 
            // cameraTextBox
            // 
            this.cameraTextBox.Location = new System.Drawing.Point(405, 36);
            this.cameraTextBox.Name = "cameraTextBox";
            this.cameraTextBox.Size = new System.Drawing.Size(52, 23);
            this.cameraTextBox.TabIndex = 10;
            this.cameraTextBox.Text = "Camera:";
            // 
            // cameraTicker
            // 
            this.cameraTicker.Interval = 1000;
            this.cameraTicker.Tick += new System.EventHandler(this.cameraTicker_Tick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(597, 341);
            this.saveButton.Name = "saveButton";
            this.saveButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // removeAllImageButton
            // 
            this.removeAllImageButton.Location = new System.Drawing.Point(549, 412);
            this.removeAllImageButton.Name = "removeAllImageButton";
            this.removeAllImageButton.Size = new System.Drawing.Size(123, 23);
            this.removeAllImageButton.TabIndex = 12;
            this.removeAllImageButton.Text = "Remove all Images";
            this.removeAllImageButton.UseVisualStyleBackColor = true;
            this.removeAllImageButton.Click += new System.EventHandler(this.Remove_All_Images);
            // 
            // numImagesText
            // 
            this.numImagesText.Location = new System.Drawing.Point(405, 378);
            this.numImagesText.Name = "numImagesText";
            this.numImagesText.Size = new System.Drawing.Size(75, 23);
            this.numImagesText.TabIndex = 13;
            this.numImagesText.Text = "# of Images:";
            // 
            // removeLastImageButton
            // 
            this.removeLastImageButton.Location = new System.Drawing.Point(405, 412);
            this.removeLastImageButton.Name = "removeLastImageButton";
            this.removeLastImageButton.Size = new System.Drawing.Size(138, 23);
            this.removeLastImageButton.TabIndex = 15;
            this.removeLastImageButton.Text = "Remove Last Image";
            this.removeLastImageButton.UseVisualStyleBackColor = true;
            this.removeLastImageButton.Click += new System.EventHandler(this.Remove_Last_Image);
            // 
            // numImages
            // 
            this.numImages.Location = new System.Drawing.Point(486, 378);
            this.numImages.Name = "numImages";
            this.numImages.Size = new System.Drawing.Size(37, 23);
            this.numImages.TabIndex = 16;
            this.numImages.Text = "0";
            // 
            // ConditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 477);
            this.Controls.Add(this.numImages);
            this.Controls.Add(this.removeLastImageButton);
            this.Controls.Add(this.numImagesText);
            this.Controls.Add(this.removeAllImageButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cameraTextBox);
            this.Controls.Add(this.systemCameraList);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cameraDisplay);
            this.Controls.Add(this.Group);
            this.Name = "ConditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtensionLadder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConditionForm_FormClosing);
            this.Load += new System.EventHandler(this.ExtensionLadder_Load);
            this.Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cameraDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NextButtonExten;
        private System.Windows.Forms.Panel Group;
        private System.Windows.Forms.PictureBox cameraDisplay;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ComboBox systemCameraList;
        private System.Windows.Forms.TextBox cameraTextBox;
        private System.Windows.Forms.Timer cameraTicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeAllImageButton;
        private System.Windows.Forms.TextBox numImagesText;
        private System.Windows.Forms.Button removeLastImageButton;
        private System.Windows.Forms.TextBox numImages;
    }
}