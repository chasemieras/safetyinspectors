using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace SafetyInspectionApp
{
    public partial class StarterForm : Form
    {

        FormHelper formHelper = new FormHelper();
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public StarterForm()
        {
            InitializeComponent();
        }

        private void StarterForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                systemCameraList.Items.Add(filterInfo.Name);
            systemCameraList.SelectedIndex = 0;
        }

        private void startCamera_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[systemCameraList.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += CaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            cameraTicker.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraDisplay.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void cameraTicker_Tick(object sender, EventArgs e)
        {
            if (cameraDisplay.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)cameraDisplay.Image);
                if (result != null)
                {
                    if (result.ToString().Equals("1"))
                    {
                        if (videoCaptureDevice.IsRunning)
                            videoCaptureDevice.SignalToStop();
                        Form selectedForm;
                        selectedForm = new LadderFormMain();
                        formHelper.setUpForm(selectedForm, this);
                    }
                    if (videoCaptureDevice.IsRunning)
                        videoCaptureDevice.SignalToStop();
                    cameraTicker.Stop();
                }
            }
        }

        private void StarterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.SignalToStop();
        }
    }
}
