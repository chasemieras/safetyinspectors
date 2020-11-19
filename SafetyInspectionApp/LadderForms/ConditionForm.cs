using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SafetyInspectionApp.LadderForms
{
    public partial class ConditionForm : Form
    {
       
        FormHelper formHelper = new FormHelper();
        Panel conditionGroup = new System.Windows.Forms.Panel();

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        List<Image> imagesList = new List<Image>();

        public ConditionForm()
        {
            InitializeComponent();
        }

        private void ConditionForm_FormClosing(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
            }
            System.Windows.Forms.Application.Exit();
        }

        private void NextButtonExten_Click(object sender, EventArgs e)
        {
            Form closeForm;
            closeForm = new EndOfForm();
            formHelper.sendInfoToSheet(conditionGroup);
            formHelper.sendInfoToSheet(imagesList);
            formHelper.setUpForm(closeForm, this);
        }

        private void ExtensionLadder_Load(object sender, EventArgs e)
        {
            int locationX = 10;
            int locationY = 20;

            conditionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            conditionGroup.Location = new System.Drawing.Point(locationX, locationY);
            conditionGroup.Name = "conditionSection";
            conditionGroup.Size = new System.Drawing.Size(Group.Width - 20 , Group.Height / 2);
            conditionGroup.AutoScroll = true;
            conditionGroup.BorderStyle = BorderStyle.FixedSingle;
            Group.Controls.Add(conditionGroup);

            formHelper.createSectionLadderCondition(locationX, locationY, conditionGroup);

            //Sets up systemCameraList with the camera options
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                systemCameraList.Items.Add(filterInfo.Name);
            }

            if (systemCameraList.Items.Count < 0)
            {
                systemCameraList.SelectedIndex = 0;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (systemCameraList.Items.Count !< 0)
            {
                stopButton_Click();
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[systemCameraList.SelectedIndex].MonikerString);
                if (videoCaptureDevice.IsRunning)
                {
                    cameraTicker.Stop();
                    videoCaptureDevice.SignalToStop();
                }
                cameraDisplay.SizeMode = PictureBoxSizeMode.Zoom;
                videoCaptureDevice.NewFrame += CaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                cameraTicker.Start();
                //imageList.ImageSize = new Size(cameraDisplay.Width, cameraDisplay.Height);
            }
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraDisplay.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            cameraTicker.Stop();
            videoCaptureDevice.SignalToStop();
        }
        private void stopButton_Click()
        {
            cameraTicker.Stop();
            videoCaptureDevice.SignalToStop();
        }

        private void cameraTicker_Tick(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int number = int.Parse(numImages.Text);
            number++;
            numImages.Text = number.ToString();
            imagesList.Add(cameraDisplay.Image);
        }

        private void Remove_Last_Image(object sender, EventArgs e)
        {
            imagesList.RemoveAt(imagesList.Count-1);
            int number = int.Parse(numImages.Text);
            number--;
            numImages.Text = number.ToString();
        }

        private void Remove_All_Images(object sender, EventArgs e)
        {
            imagesList.Clear();
            int number = int.Parse(numImages.Text);
            number = 0;
            numImages.Text = number.ToString();
        }
    }
}
