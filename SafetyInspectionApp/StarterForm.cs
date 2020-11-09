using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        GoogleSheetHelper sheetHelper = new GoogleSheetHelper();
        FormSettings formSettings = new FormSettings();

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public StarterForm()
        {
            InitializeComponent();
        }

        private void StarterForm_Load(object sender, EventArgs e)
        {
            //Sets up systemCameraList with the camera options
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection) 
            {
                systemCameraList.Items.Add(filterInfo.Name);
            }
            systemCameraList.SelectedIndex = 0;

            //Sets up the dropdown list of options for selecting a form to complete
            string[] formSelectionItems = formSettings.KEY_WORDS_FOR_FORM_SELECTION;
            foreach (string possibleForm in formSelectionItems) 
            {
                formSelectionList.Items.Add(possibleForm);
            }
            formSelectionList.SelectedIndex = -1;
        }

        private void startCamera_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[systemCameraList.SelectedIndex].MonikerString);
            if (videoCaptureDevice.IsRunning) 
            {
                videoCaptureDevice.Stop();
                cameraTicker.Stop();
            }
            cameraDisplay.SizeMode = PictureBoxSizeMode.Zoom;
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
                    foreach (string form in formSettings.KEY_WORDS_FOR_FORM_SELECTION) 
                    {
                        if (result.ToString().Equals("form"))
                        {
                            if (videoCaptureDevice.IsRunning)
                            {
                                videoCaptureDevice.SignalToStop();
                            }
                            //TO DO, ADD QUESTION SELECTION
                            formHelper.starterNextForm(this);

                        }
                        else
                    if (videoCaptureDevice.IsRunning)
                        {
                            videoCaptureDevice.SignalToStop();
                        }
                        cameraTicker.Stop();
                    }
                }
            }
        }

        private void StarterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning) 
            {
                videoCaptureDevice.SignalToStop();
            }

            System.Windows.Forms.Application.Exit();

        }

        private void formSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stringToCompare = formSelectionList.SelectedItem.ToString();
            foreach (string form in formSettings.KEY_WORDS_FOR_FORM_SELECTION) 
            {
                if (stringToCompare.Equals(form))
                {
                    //TO DO, ADD QUESTION SELECTION
                    formHelper.starterNextForm(this);
                }
                else 
                {
                    formSelectionList.SelectedIndex = -1;
                }
            }
        }
    }
}
